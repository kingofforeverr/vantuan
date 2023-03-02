n = int(input("Nhập một số nguyên dương n (0<=n<=9999): "))

if n == 0:  # Trường hợp riêng nếu n = 0
    print("Số chữ số của n là 1")
else:
    count = 0  # Biến đếm số chữ số của n
    n_copy = n  # Tạo một bản sao của n để tính số chữ số
    while n_copy > 0:
        count += 1
        n_copy //= 10  # Lấy phần nguyên của phép chia cho 10
    print(n, "có", count, "chữ số")
