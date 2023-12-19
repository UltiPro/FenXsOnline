let hoverTimer;

// Create a draggable div
$(document).on("dragstart", ".item-image", function (event) {
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
    const draggedItem = $(".item-image.dragging");
    const dropTarget = $(this);
    const ancestor = draggedItem.closest(".eq-slot");
    const fromId = draggedItem.parent().attr("id");
    const toId = dropTarget.attr("id");
    const cleanToId = toId.replace("s", "");
    //check if source parent contains .eq-slot
    if (ancestor.length > 0) {
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
        if (DoesEqSlotFitsItemType === true) {
            swapItems(cleanFromId, toId)
                .then((flag) => {
                    if (flag === true) {
                        existingItem.removeClass();
                        dropTarget.append(draggedItem);

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

function updateItemPosition(oldId, newId) {
    let EQdetails = getEquipmentDetails();
    let BPdetails = getBackpackDetails();
    if (isNaN(oldId) || isNaN(newId)) {
        if (isNaN(oldId)) {
            const itemType = parseEqId(oldId);
            const alphaIndex = EQdetails.findIndex((item) => item.slotInfo === itemType);
            let itemToMove = EQdetails.splice(alphaIndex, 1)[0];
            console.log("BPdetails new item: " + itemToMove);
            itemToMove.slotInfo = newId;
            BPdetails.push(itemToMove);
        } else {
            const itemType = parseEqId(newId);
            const betaIndex = BPdetails.findIndex((item) => item.slotInfo === oldId);
            let itemToMove = BPdetails.splice(betaIndex, 1)[0];
            console.log("EQdetails new item: " + itemToMove);
            itemToMove.slotInfo = itemType;
            EQdetails.push(itemToMove);
        }
    } else {
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
    if (x.itemDetails.itemType === type) {
        return true;
    } else {
        return false;
    }
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
    if ($(element).hasClass("stat-icon")) {
        const iconInfo = $(element).attr('icon-info');
        const mouseX = event.clientX;
        const mouseY = event.clientY;

        const infoDiv = $(`<div id="infoDiv" class="info-box">${iconInfo}</div>`);
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
            zIndex: "9999"
        });

        $("body").append(infoDiv);
    }
}

