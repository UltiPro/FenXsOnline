// Create a draggable div
for (let i = 1; i <= 29; i++) {
    var draggableDiv = $(`<div class="item-image" draggable="true">${i}</div>`);
    $(`#s${i}`).append(draggableDiv);
}

// Add drag event listeners to all draggable items
$('.item-image').on('dragstart', function(event) {
    if ($(this).html() !== '') {
        event.originalEvent.dataTransfer.setData('text/plain', $(this).attr('id'));
        $(this).addClass('dragging');
        $(this).css('transform', 'scale(1.1)'); // Adjust scale as needed
    } else {
        event.preventDefault();
    }
});

//handling drag end
$('.item-image').on('dragend', function() {
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

    // Check if there's a child within the drop target
    if (dropTarget.children('.item-image').length > 0) {
        // Get the existing item in the slot
        var existingItem = dropTarget.children('.item-image');

        // Swap the dragged item with the existing item in the slot
        draggedItem.after(existingItem);
        dropTarget.append(draggedItem);
    } else {
        // If the slot is empty, simply append the dragged item
        dropTarget.append(draggedItem);
    }
});
