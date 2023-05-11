import re

# Nhập chuỗi chứa họ tên và email từ người dùng
input_str = input()

# Tìm kiếm email trong chuỗi
match = re.search(r'\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b', input_str)

# Nếu tìm thấy email, in kết quả ra màn hình
if match:
    print(match.group())
else:
    print()
