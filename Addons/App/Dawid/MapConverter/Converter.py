from PIL import Image, ImageSequence
import tkinter as tk
from tkinter import filedialog

def check_color_block(img, x, y):
    green_threshold = 200  # Adjust this threshold as needed
    red_threshold = 150  # Adjust this threshold as needed
    blue_threshold = 150  # Adjust this threshold as needed
    
    green_count = 0
    red_count = 0
    blue_count = 0

    for i in range(x, x + 32):
        for j in range(y, y + 32):
            if i < img.width and j < img.height:
                pixel = img.getpixel((i, j))
                if isinstance(pixel, int):  # For grayscale images
                    if pixel > green_threshold:
                        green_count += 1
                    elif pixel < red_threshold:
                        red_count += 1
                    elif pixel > blue_threshold:
                        blue_count += 1
                else:  # For RGB images
                    r, g, b = pixel[:3]
                    if g >= green_threshold and r < red_threshold:
                        green_count += 1
                    elif r >= red_threshold and g < green_threshold:
                        red_count += 1
                    elif b >= blue_threshold:
                        blue_count += 1
    
    return (green_count > red_count) or (blue_count > green_count + red_count), blue_count > green_count + red_count

def process_image(image_path):
    img = Image.open(image_path)
    rows = img.height // 32
    cols = img.width // 32

    output_data = []
    output_data_blue = []

    for y in range(0, img.height, 32):
        row_data = []
        row_data_blue = []
        for x in range(0, img.width, 32):
            is_green, is_blue = check_color_block(img, x, y)
            row_data.append(str(is_green))
            row_data_blue.append(str(is_blue))
        output_data.append(' '.join(row_data))
        output_data_blue.append(' '.join(row_data_blue))

    # Save the boolean values to text files with rows and cols
    with open('output_green_red.txt', 'w') as file:
        file.write('\n'.join(output_data))

    with open('output_blue.txt', 'w') as file:
        file.write('\n'.join(output_data_blue))

def select_file():
    root = tk.Tk()
    root.withdraw()
    file_path = filedialog.askopenfilename(title="Select Image File", filetypes=[("Image Files", "*.png;*.jpg;*.jpeg;*.gif;*.bmp")])
    if file_path:
        process_image(file_path)

select_file()


# OLD LOGIC
# from PIL import Image, ImageSequence
# import tkinter as tk
# from tkinter import filedialog

# def check_color_block(img, x, y):
#     green_threshold = 200  # Adjust this threshold as needed
#     red_threshold = 150  # Adjust this threshold as needed
    
#     green_count = 0
#     red_count = 0

#     for i in range(x, x + 32):
#         for j in range(y, y + 32):
#             if i < img.width and j < img.height:
#                 pixel = img.getpixel((i, j))
#                 if isinstance(pixel, int):  # For grayscale images
#                     if pixel > green_threshold:
#                         green_count += 1
#                     elif pixel < red_threshold:
#                         red_count += 1
#                 else:  # For RGB images
#                     r, g, b = pixel[:3]
#                     if g >= green_threshold and r < red_threshold:
#                         green_count += 1
#                     elif r >= red_threshold and g < green_threshold:
#                         red_count += 1
    
#     return green_count > red_count

# def process_image(image_path):
#     img = Image.open(image_path)
#     rows = img.height // 32
#     cols = img.width // 32

#     output_data = []

#     for y in range(0, img.height, 32):
#         row_data = []
#         for x in range(0, img.width, 32):
#             is_green = check_color_block(img, x, y)
#             row_data.append(str(is_green))
#         output_data.append(' '.join(row_data))

#     # Save the boolean values to a text file with rows and cols
#     with open('output.txt', 'w') as file:
#         file.write('\n'.join(output_data))

# def select_file():
#     root = tk.Tk()
#     root.withdraw()
#     file_path = filedialog.askopenfilename(title="Select Image File", filetypes=[("Image Files", "*.png;*.jpg;*.jpeg;*.gif;*.bmp")])
#     if file_path:
#         process_image(file_path)

# select_file()
