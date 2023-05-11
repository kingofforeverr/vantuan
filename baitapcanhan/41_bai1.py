string = input()
hoa = 0
thuong = 0
so = 0
dacbiet = 0

for char in string:
    # Kiểm tra ký tự có phải là chữ cái in hoa
    if char.isupper():
        hoa += 1
    # Kiểm tra ký tự có phải là chữ cái in thường
    elif char.islower():
        thuong += 1
    # Kiểm tra ký tự có phải là chữ số
    elif char.isdigit():
        so += 1
    # Các ký tự khác được xem là ký tự đặc biệt
    else:
        dacbiet += 1

# In kết quả ra màn hình
print("In hoa:", hoa)
print("In thuong:", thuong)
print("Chu so:", so)
print("Khac:", dacbiet)
