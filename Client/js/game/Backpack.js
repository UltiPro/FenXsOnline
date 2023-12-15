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
    var draggedItem = $('.item-image.dragging');
    var dropTarget = $(this);

    var fromId = draggedItem.parent().attr('id');
    var toId = dropTarget.attr('id');

    if (fromId !== toId) {
        // Swap the dragged item with the existing item in the slot
        var existingItem = dropTarget.children('.item-image');
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

function swapItems(fromId, toId) {
    console.log(`From ID: ${fromId}, To ID: ${toId}`); // Debug log to check the IDs

    // Ensure 'app' is correctly initialized and reachable in this scope
    app.put(apiBaseUrl+`Equipment/move-item?fromId=${fromId}&toId=${toId}`)
        .then(_ => {
            console.log(`Item from ${fromId} was dragged to ${toId}`);
        })
        .catch(error => {
            console.error("Error moving item:", error);
        });
}