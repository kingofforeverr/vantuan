n = int(input("n="))

# Kiểm tra giá trị n
if n < 0 or n > 100:
    print("Số n không hợp lệ.")
else:
    # Tính giai thừa của n
    giaithua = 1
    for i in range(1, n+1):
        giaithua *= i

    # In kết quả lên màn hình
    print(str(n) + "! =", giaithua)
