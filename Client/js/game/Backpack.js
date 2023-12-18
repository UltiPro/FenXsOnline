// Create a draggable div
$(document).on('dragstart', '.item-image', function(event) {
    if ($(this).html() !== '') {
        event.originalEvent.dataTransfer.setData('text/plain', $(this).attr('id'));
        $(this).addClass('dragging');
        $(this).css('transform', 'scale(1.1)'); // Adjust scale as needed
    } else {
        event.preventDefault();
    }
});

// Drag end event listener delegated to a parent element
$(document).on('dragend', '.item-image', function() {
    $(this).removeClass('dragging');
    $(this).css('transform', 'scale(1)'); 
});

// Add drop event listeners to all .bp-slot elements
$('.bp-slot').on('dragover', function(event) {
    event.preventDefault();
});

$('.bp-slot').on('drop', function(event) {
    event.preventDefault();
    const draggedItem = $('.item-image.dragging');
    const dropTarget = $(this);
    const ancestor = draggedItem.closest('.eq-slot')
    const fromId = draggedItem.parent().attr('id');
    const toId = dropTarget.attr('id');
    //fromId can mean that I move item from equipment
    //check if target's parent contains .eq-slot
    if(ancestor.length > 0){
        Unequip()
    }
    if (fromId !== toId) {
        // Swap the dragged item with the existing item in the slot
        const existingItem = dropTarget.children('.item-image');
        draggedItem.after(existingItem);
        dropTarget.append(draggedItem);
        //removing letter s
        const cleanFromId = fromId.replace('s', '');
        const cleanToId = toId.replace('s', '');    
        swapItems(cleanFromId, cleanToId);
    } else {
        console.log("Item moved within the same slot. No API call needed.");
    }
});

$('.eq-slot').on('dragover', function(event) {
    event.preventDefault();
});

$('.eq-slot').on('drop', function(event) {
    event.preventDefault();
    const draggedItem = $('.item-image.dragging');
    const dropTarget = $(this);
    const ancestor = draggedItem.closest('.bp-slot')
    const fromId = draggedItem.parent().attr('id');
    const toId = dropTarget.attr('id');
    const cleanFromId = fromId.replace('s', '');
    let existingItem = dropTarget.children('.item-image');

    //fromId can mean that I move item from equipment
    //check if parent contains .bp-slot
    if (ancestor.length > 0) {
        const DoesEqSlotFitsItemType = Equip(cleanFromId, toId)
        if (DoesEqSlotFitsItemType === true) {
            swapItems(cleanFromId, toId)
                .then(flag => {
                    if (flag === true) {
                        dropTarget.append(draggedItem);
                        existingItem.removeClass();
                    }
                })
                .catch(error => {
                    console.error('Error in swapItems:', error);
                });
        }
    }
    else if(fromId !== toId) {
        // Swap the dragged item with the existing item in the slot
        draggedItem.after(existingItem);
        dropTarget.append(draggedItem);
        //removing letter s
        const cleanToId = toId.replace('s', ''); 
        swapItems(cleanFromId, cleanToId);
    } else {
        console.log("Item moved within the same slot or two eq slots. No API call needed.");
    }
});

function swapItems(fromId, toId) {
    return new Promise((resolve, reject) => {
        if (isNaN(fromId)) {
            app.put(apiBaseUrl + `Equipment/unuse-item?itemType=0&slotId=12`)
                .then(_ => {
                    console.log(`Item from ${fromId} was UNEQUIPPED to ${toId}`);
                    resolve(true);
                })
                .catch(error => {
                    console.error("Error moving item:", error);
                    reject(false);
                });
        } else if (isNaN(toId)) {
            app.put(apiBaseUrl + `Equipment/use-item?slotId=${fromId}`)
                .then(_ => {
                    console.log(`Item from ${fromId} was EQUIPPED to ${toId}`);
                    resolve(true);
                })
                .catch(error => {
                    console.error("Error moving item:", error);
                    reject(false);
                });
        } else {
            console.log(`From ID: ${fromId}, To ID: ${toId}`);
            app.put(apiBaseUrl + `Equipment/move-item?fromId=${fromId}&toId=${toId}`)
                .then(_ => {
                    console.log(`Item from ${fromId} was dragged to ${toId}`);
                    resolve(true);
                })
                .catch(error => {
                    console.error("Error moving item:", error);
                    reject(false);
                });
        }
    });
}

function Unequip(){
    console.log("Unequip")
}

function Equip(fromId, toId){
    let details = Test()
    const x = details.find(item => item.slotInfo === fromId);
    let type = ParseEqId(toId)
    if(x.itemDetails.itemType === type){
        return true;
    }
    else{
        return false;
    }
    
    console.log("Equip")
}

function ParseEqId(toId){
    switch(toId){
        case "dbWeapon" : return 0;
        case "dbSecondaryWeapon" : return 1;
        case "dbArmor" : return 2;
        case "dbHelmet" : return 3;
        case "dbBoots" : return 4;
        case "dbGloves" : return 5;
        case "dbNecklace" : return 6;
        case "dbRing" : return 7;     
    }
}