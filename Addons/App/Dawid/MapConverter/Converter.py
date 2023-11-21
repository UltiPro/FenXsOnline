from PIL import Image, ImageSequence
import tkinter as tk
from tkinter import filedialog

def check_color_block(data, x, y, width, height):
    green_threshold = 200  # Adjust this threshold as needed
    red_threshold = 150  # Adjust this threshold as needed

    green_count = 0
    red_count = 0

    for i in range(x, min(x + 32, width)):
        for j in range(y, min(y + 32, height)):
            pixel_index = j * width + i
            pixel = data[pixel_index]
            r, g, b = pixel[0], pixel[1], pixel[2]  # Extract RGB values
            if g > green_threshold and r < red_threshold:
                green_count += 1
            elif r > red_threshold and g < green_threshold:
                red_count += 1

    return green_count > red_count

def process_image(image_path):
    img = Image.open(image_path)

    # If the image is a GIF, take the first frame as a static image
    if img.is_animated:
        frames = list(ImageSequence.Iterator(img))
        img = frames[0]

    width, height = img.size
    data = list(img.getdata())

    rows = height // 32
    cols = width // 32

    output_data = []
    for y in range(0, height, 32):
        for x in range(0, width, 32):
            is_green = check_color_block(data, x, y, width, height)
            output_data.append(str(is_green))

    # Reshape data into rows and cols
    reshaped_data = [output_data[i:i + cols] for i in range(0, len(output_data), cols)]

    # Save the boolean values to a text file with rows and cols
    with open('output.txt', 'w') as file:
        for row in reshaped_data:
            file.write(' '.join(row) + '\n')

def select_file():
    root = tk.Tk()
    root.withdraw()
    file_path = filedialog.askopenfilename(title="Select Image File", filetypes=[("Image Files", "*.png;*.jpg;*.jpeg;*.gif;*.bmp")])
    if file_path:
        process_image(file_path)

select_file()