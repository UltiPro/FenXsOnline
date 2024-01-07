from PIL import Image
import tkinter as tk
from tkinter import filedialog

def check_color_block(img, x, y):
    green_threshold = 200  # Adjust this threshold as needed
    red_threshold = 150  # Adjust this threshold as needed
    blue_threshold = 150  # Adjust this threshold as needed
    
    unique_colors = set()
    for i in range(x, x + 32):
        for j in range(y, y + 32):
            if i < img.width and j < img.height:
                pixel = img.getpixel((i, j))
                if isinstance(pixel, int):  # For grayscale images
                    unique_colors.add(pixel)
                else:  # For RGB images
                    unique_colors.add(pixel[:3])

    if len(unique_colors) == 1:  # Tile has only one color
        color = next(iter(unique_colors))  # Get the color
        if isinstance(color, int):  # For grayscale images
            if color > green_threshold:
                return 'G'
            elif color < red_threshold:
                return 'R'
            elif color < blue_threshold:
                return 'B'
        else:  # For RGB images
            r, g, b = color
            if g >= green_threshold and r < red_threshold:
                return 'G'
            elif r >= red_threshold and g < green_threshold:
                return 'R'
            elif b >= blue_threshold and r < red_threshold and g < green_threshold:
                return 'B'

    return 'Mixed'  # Tile has multiple colors

def process_image(image_path):
    img = Image.open(image_path)

    collisions_data = []
    zindex_data = []
    error_coordinates = []
    log_messages = []

    for y in range(0, img.height, 32):
        collisions_row = []
        zindex_row = []
        for x in range(0, img.width, 32):
            log_messages.append(f"Processing tile at ({x}, {y})")
            color = check_color_block(img, x, y)
            if color == 'R':
                collisions_row.append('True, ')
                zindex_row.append('False, ')
            elif color == 'G':
                collisions_row.append('False, ')
                zindex_row.append('False, ')
            elif color == 'B':
                collisions_row.append('False, ')
                zindex_row.append('True, ')
            else:
                error_coordinates.append((x, y))
                collisions_row.append('Error')
                zindex_row.append('Error')
                log_messages.append(f"Tile at ({x}, {y}) contains multiple colors.")

        collisions_data.append(' '.join(collisions_row))
        zindex_data.append(' '.join(zindex_row))

    # Save the boolean values to two separate text files
    with open('Collisions.txt', 'w') as collisions_file:
        collisions_file.write('\n'.join(collisions_data))

    with open('Zindex.txt', 'w') as zindex_file:
        zindex_file.write('\n'.join(zindex_data))

    # Log messages to a file
    with open('logs.txt', 'w') as logs_file:
        logs_file.write('\n'.join(log_messages))
        
    # Print out error coordinates to logs file
    if error_coordinates:
        with open('logs.txt', 'a') as logs_file:
            logs_file.write("\nCoordinates of tiles with multiple colors:\n")
            logs_file.write('\n'.join(str(coord) for coord in error_coordinates))

def select_file():
    root = tk.Tk()
    root.withdraw()
    file_path = filedialog.askopenfilename(title="Select Image File", filetypes=[("Image Files", "*.png;*.jpg;*.jpeg;*.gif;*.bmp")])
    if file_path:
        process_image(file_path)

select_file()