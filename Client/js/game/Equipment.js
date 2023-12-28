let hoverTimer;

// Create a draggable div
$(document).on("dragstart", ".item-image", function (event) {
    $("#infoDiv").remove();
    if ($(this).html() !== "") {
        event.originalEvent.dataTransfer.setData("text/plain", $(this).attr("id"));
        $(this).addClass("dragging");
        $(this).css("transform", "scale(1.1)"); // Adjust scale as needed
    } else {
        event.preventDefault();
    }
});

// Drag end event listener delegated to a parent element
$(document).on("dragend", ".item-image", function () {
    $(this).removeClass("dragging");
    $(this).css("transform", "scale(1)");
});

// Add drop event listeners to all .bp-slot elements
$(".bp-slot").on("dragover", function (event) {
    event.preventDefault();
});

$(".bp-slot").on("drop", function (event) {
    event.preventDefault();
    let draggedItem = $(".item-image.dragging");
    const dropTarget = $(this);
    const ancestorEq = draggedItem.closest(".eq-slot");
    const ancestorShop = draggedItem.closest(".shop-slot")
    const fromId = draggedItem.parent().attr("id");
    const toId = dropTarget.attr("id");
    const cleanToId = toId.replace("s", "");
    //check if item is from shop, buying item
    if(ancestorShop.length > 0){
        const cleanFromId = fromId.replace("s", "")
        buyItem(cleanFromId)
        setTimeout(() => {
            updateHeroStatLabels();
        }, 2000);

    }
    //check if source parent contains .eq-slot, Uneqiping
    else if (ancestorEq.length > 0) {
        const absent = $(`<div class="item-image item-opacity"></div>`);

        swapItems(fromId, cleanToId)
            .then((flag) => {
                if (flag === true) {
                    draggedItem.parent().append(absent);
                    dropTarget.append(draggedItem);
                    const newItemDetails = updateItemPosition(fromId, cleanToId);

                    updateHeroStatLabels();
                }
            })
            .catch((err) => {
                console.log("Error in swapItem: ", err);
            });
    } else if (fromId !== toId) {
        const existingItem = dropTarget.children(".item-image");
        draggedItem.after(existingItem);
        dropTarget.append(draggedItem);
        const cleanFromId = fromId.replace("s", "");
        const newItemDetails = updateItemPosition(cleanFromId, cleanToId);
        swapItems(cleanFromId, cleanToId);
        setBackpackDetails(newItemDetails);
    } else {
        console.log("Item moved within the same slot. No API call needed.");
    }
    setTimeout(() => {
        updateHeroStatLabels();
    }, 2000);
});

$(".eq-slot").on("dragover", function (event) {
    event.preventDefault();
});

$(".eq-slot").on("drop", function (event) {
    event.preventDefault();
    const draggedItem = $(".item-image.dragging");
    const dropTarget = $(this);
    const ancestor = draggedItem.closest(".bp-slot");
    const fromId = draggedItem.parent().attr("id");
    const toId = dropTarget.attr("id");
    const cleanFromId = fromId.replace("s", "");
    let existingItem = dropTarget.children(".item-image");

    //if hero will meet al requirements for item, but already have
    //item equipped at this slot break equipping another item
    if (!dropTarget.children().hasClass("item-opacity")) {
        console.log("Hero has already equipped item of this type");
    }
    //check if source parent contains .bp-slot
    else if (ancestor.length > 0) {
        const DoesEqSlotFitsItemType = Equip(cleanFromId, toId);
        if (DoesEqSlotFitsItemType === 1 || DoesEqSlotFitsItemType === 2) {
            swapItems(cleanFromId, toId)
                .then((flag) => {
                    if (flag === true) {
                        if (DoesEqSlotFitsItemType === 2)
                        {
                            draggedItem.remove();
                        }else{
                            existingItem.removeClass();
                            dropTarget.append(draggedItem);
                        }
                        
                        
                        updateItemPosition(cleanFromId, toId);
                        updateHeroStatLabels();
                    }
                })
                .catch((error) => {
                    console.error("Error in swapItems:", error);
                });
        }
    } else {
        console.log("Item moved within two eq slots. No API call needed.");
    }
    setTimeout(() => {
        updateHeroStatLabels();
    }, 2000);
});

$(document).on("dragover", ".shop-slot", function (event) {
    event.preventDefault();
});

//Shop-slots event listning
$(document).on("drop", ".shop-slot", function (event) {
    event.preventDefault();
    const draggedItem = $(".item-image.dragging");
    const dropTarget = $(this);
    const ancestor = draggedItem.closest(".bp-slot");
    const fromId = draggedItem.parent().attr("id");
    const toId = dropTarget.attr("id");
    const cleanFromId = fromId.replace("s", "")
    if (draggedItem.parent().hasClass("shop-slot") && dropTarget.hasClass("shop-slot")) {
        console.log("Both items are from shop-slot, nothing should happen");
    }
    else if(draggedItem.parent().hasClass("eq-slot")){
        console.log("Item moved from eq-slot cannot be selled, move item to backack")
    }
    else{
        sellItem(cleanFromId);
        console.log(ancestor)
        $(ancestor).empty();
        setTimeout(() => { //making sure stats were refreashed
            updateHeroStatLabels();
        }, 2000);
    }
});

function buyItem(cleanFromId) {
    let BPdetails = getBackpackDetails();
    let shop = getShopDetails();
    console.log(cleanFromId)

    const firstEmptySlot = $(".bp-slot").filter(function() {
        return $(this).children().length === 0; // Filter empty slots
    }).first();
    slotForBoughtItem = firstEmptySlot.attr("id").replace("s", "")
    console.log(slotForBoughtItem)
    
    const itemIndex = shop.findIndex((item) => item.slotInfo === cleanFromId);
    let itemFromShop = shop[itemIndex]

    // Check if there is a cloned item already present and remove it
    $('#infoDiv').remove(); // Remove any existing infoDiv

    const existingClone = $(".item-image.dragging-clone");
    if (existingClone.length > 0) {
        existingClone.remove();
    }

    // Item cloned from source
    const draggedItemClone = $(".item-image.dragging").clone().addClass('dragging-clone'); // Add a unique class
    console.log(draggedItemClone)
    app.put(apiBaseUrl + `Npc/buy?npcId=${itemFromShop.npcId}&itemId=${itemFromShop.slotInfo}`).then((_) =>{
        delete itemFromShop.npcId;
        itemFromShop.slotInfo = slotForBoughtItem;
        BPdetails.push(itemFromShop);
        setBackpackDetails(BPdetails);
        draggedItemClone.css("opacity", "1");
        firstEmptySlot.append(draggedItemClone);
        updateHeroStatLabels();
    }).catch((err) => {
        console.log("Error npc/buy endpoint", err);
        return "ITEM_BUY_ERROR";
    });
}


function sellItem(cleanFromId) {
    let BPdetails = getBackpackDetails();
    const itemIndex = BPdetails.findIndex((item) => item.slotInfo === cleanFromId); //finding item ID
    if (itemIndex !== -1) {
        const itemToSell = BPdetails[itemIndex]; //selecting item from backpack
        app.put(apiBaseUrl + `Npc/sell?npcId=1&itemId=${itemToSell.slotInfo}`)
            .then((_) => {
                BPdetails.splice(itemIndex, 1);
                setBackpackDetails(BPdetails); //removing item from backpack local list
                updateHeroStatLabels(); //gold UI update
                console.log(`Item sold successfully.`);
            })
            .catch((error) => {
                console.error("Error selling item:", error);
            });
    } else {
        console.log("Item not found in the hero's backpack.");
    }
}

function swapItems(fromId, toId) {
    return new Promise((resolve, reject) => {
        if (isNaN(fromId)) {
            const itemType = parseEqId(fromId);
            app.put(apiBaseUrl + `Equipment/unuse-item?itemType=${itemType}&slotId=${toId}`)
                .then((_) => {
                    console.log(`Item ${fromId} was UNEQUIPPED to slot ${toId}`);
                    resolve(true);
                })
                .catch((error) => {
                    console.error("Error moving item:", error);
                    reject(false);
                });
        } else if (isNaN(toId)) {
            app.put(apiBaseUrl + `Equipment/use-item?slotId=${fromId}`)
                .then((_) => {
                    console.log(`Item from slot ${fromId} was EQUIPPED as ${toId}`);
                    resolve(true);
                })
                .catch((error) => {
                    console.error("Error moving item:", error);
                    reject(false);
                });
        } else {
            app.put(apiBaseUrl + `Equipment/move-item?fromId=${fromId}&toId=${toId}`)
                .then((_) => {
                    console.log(`Item from slot ${fromId} was dragged to slot ${toId}`);
                    resolve(true);
                })
                .catch((error) => {
                    console.error("Error moving item:", error);
                    reject(false);
                });
        }
    });
}

//updating local EQ,BP local lists 
function updateItemPosition(oldId, newId) {
    let EQdetails = getEquipmentDetails();
    let BPdetails = getBackpackDetails();
    if (isNaN(oldId) || isNaN(newId)) {
        if (isNaN(oldId)) {
            //Unequiping item, removing item from EQdetails and pushing to BPdetails
            const itemType = parseEqId(oldId);
            const alphaIndex = EQdetails.findIndex((item) => item.slotInfo === itemType);
            let itemToMove = EQdetails.splice(alphaIndex, 1)[0];
            console.log("BPdetails new item: " + itemToMove);
            itemToMove.slotInfo = newId;
            BPdetails.push(itemToMove);
        } else {
            //Equiping item, removing item from BPdetails and pushing to EQdetails
            const itemType = parseEqId(newId);
            const betaIndex = BPdetails.findIndex((item) => item.slotInfo === oldId);
            let itemToMove = BPdetails.splice(betaIndex, 1)[0];
            console.log("EQdetails new item: " + itemToMove);
            itemToMove.slotInfo = itemType;
            EQdetails.push(itemToMove);
        }
    } else {
        //Moving within backpack, updating BPdetails local list
        const alphaIndex = BPdetails.findIndex((item) => item.slotInfo === oldId);
        const betaIndex = BPdetails.findIndex((item) => item.slotInfo === newId);
        if (alphaIndex !== -1) {
            BPdetails[alphaIndex].slotInfo = newId;
            console.log("Item slotInfo updated:", BPdetails[alphaIndex]);
            if (betaIndex !== -1) {
                BPdetails[betaIndex].slotInfo = oldId;
                console.log("Item slotInfo updated:", BPdetails[betaIndex]);
            }
            return BPdetails;
        } else {
            console.log("Item with oldId not found.");
        }
    }
}

function Equip(fromId, toId) {
    let BPdetails = getBackpackDetails();
    const x = BPdetails.find((item) => item.slotInfo === fromId);
    let type = parseEqId(toId);
    if (x.itemDetails.itemType === type || x.itemDetails.itemType === 8) {
        if(x.itemDetails.itemType === 8){
            return 2;
        }
        return 1;
    } else {
        return -1;
    }
}

function showItemInfo(element, event) {
    hoverTimer = setTimeout(function () {
        showInfo(element, event);
    }, 1000);
}

function hideItemInfo() {
    clearTimeout(hoverTimer);
    $("#infoDiv").remove();
}

function showInfo(element, event) {
    const mouseX = event.clientX;
    const mouseY = event.clientY;

    if ($(element).hasClass("stat-icon")) {
        const iconInfo = $(element).attr("icon-info");

        const infoDiv = $(`<div id="infoDiv" class="info-box">${iconInfo}</div>`);
        infoDivStyling(infoDiv, mouseX, mouseY);

        $("body").append(infoDiv);
    }
    if ($(element).hasClass("item-image")) {
        const slot = $(element).parent().attr("id");
        let BPdetails = getBackpackDetails();
        let EQdetails = getEquipmentDetails();
        let shopDetails = getShopDetails();
        let item;
        if($(element).parent().hasClass("bp-slot")){
            const id = slot.replace("s", "");
            item = BPdetails.find((item) => item.slotInfo === id);
        }
        if ($(element).parent().hasClass("eq-slot")) {
            const id = parseEqId(slot);
            item = EQdetails.find((item) => item.slotInfo == id);
        }
        if($(element).parent().hasClass("shop-slot")){
            const id = slot.replace("s", "");
            item = shopDetails.find((item) => item.slotInfo === id);
        }
        
        let info = item.itemDetails;
        let infoKeys = [
            {key: info.name, label: ""},
            {key: info.atack, label: "Physical Damage: "},
            {key: info.magicAtack, label: "Magical Damage: "},
            {key: info.criticalChance, label: "Ciritical Hit Chance: "},
            {key: info.armor, label: "Physical Defence: "},
            {key: info.magicArmor, label: "Magical Defence: "},
            {key: info.healthPoints, label: "Health: "},
            {key: info.mana, label: "Mana: "},
            {key: info.agility, label: "Agility: "},
            {key: info.weight, label: "Weight: "},
            {key: info.price, label: "Price: "},
            {key: info.profession, label: "Profession: "},
            {key: info.level, label: "Level: "},
        ]
        let iconInfo = ``
        iconInfo = createIconInfo(infoKeys)
        const infoDiv = $(`<div id="infoDiv" class="info-box">${iconInfo}</div>`);
        infoDivStyling(infoDiv, mouseX, mouseY);

        $("body").append(infoDiv);

        //Adjusting placement of infoDiv if it
        //extends beyond visibliity area of our website
        const infoDivWidth = infoDiv.width();
        const infoDivHeight = infoDiv.height();
        const windowWidth = $(window).width();
        const windowHeight = $(window).height();

        const maxX = windowWidth - infoDivWidth - 10; 
        const maxY = windowHeight - infoDivHeight - 10; 

        let adjustedX = mouseX + 10; 
        let adjustedY = mouseY + 10; 
        if (adjustedX > maxX) {
            adjustedX = maxX;
        }
        if (adjustedY > maxY) {
            adjustedY = maxY;
        }

        infoDiv.css({
            top: adjustedY + "px",
            left: adjustedX + "px",
        });
    }
}

function createIconInfo(infoKeys) {
    let message = "";
    infoKeys.forEach(k => {
        if (k.label === "Profession: ") {
            let profession = parseProfession(k.key);
            message += "<br /><p>Requirements: </p>";
            if(profession !== undefined){
                let line = "<p>" + k.label + " " + profession + "</p>";
                message += line;
            }
        } else
        if (k.key !== undefined && k.key !== 0) {
                let line = "<p>" + k.label + " " + k.key + "</p>";
                message += line;
        }
    });
    return message;
}

function infoDivStyling(infoDiv, mouseX, mouseY) {
    infoDiv.css({
        position: "absolute",
        top: mouseY + "px",
        left: mouseX + "px",
        backgroundColor: "black",
        opacity: "0.8",
        padding: "5px",
        borderRadius: "8px",
        border: "1px solid goldenrod",
        fontFamily: "font_form",
        fontSize: "14px",
        color: "goldenrod",
        zIndex: "1",
    });

    infoDiv.find("p").css({
        margin: "0",
        padding: "0",
    });
}

function parseEqId(id) {
    switch (id) {
        case "dbWeapon":
            return 0;
        case "dbSecondaryWeapon":
            return 1;
        case "dbArmor":
            return 2;
        case "dbHelmet":
            return 3;
        case "dbBoots":
            return 4;
        case "dbGloves":
            return 5;
        case "dbNecklace":
            return 6;
        case "dbRing":
            return 7;
    }
}

function parseProfession(profession) {
    switch (profession) {
        case 0:
            return "Warrior";
        case 1:
            return "Mage";
        case 2:
            return "Hunter";
        case 3:
            return "Paladin";
    }
}