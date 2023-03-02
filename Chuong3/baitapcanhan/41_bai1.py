import math

# Nhập giá trị a, b, c từ bàn phím
a = float(input("Nhập giá trị a: "))
b = float(input("Nhập giá trị b: "))
c = float(input("Nhập giá trị c: "))

# Kiểm tra xem a, b, c có thể tạo thành một tam giác không
if (a + b > c) and (a + c > b) and (b + c > a):
    # Tính diện tích tam giác
    p = (a + b + c) / 2
    area = math.sqrt(p * (p - a) * (p - b) * (p - c))
    
    # In kết quả, làm tròn đến 3 chữ số lẻ
    print("Diện tích tam giác là:", round(area, 3))
else:
    # In thông báo nếu a, b, c không thể tạo thành một tam giác
    print("Không hợp lệ")
