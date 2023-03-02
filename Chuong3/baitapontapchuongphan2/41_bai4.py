while True:
    # Nhập a và b từ bàn phím
    a = float(input("a="))
    b = float(input("b="))

    # Nhập toán tử từ bàn phím
    operator = input("Nhập toán tử (+, -, *, /): ")

    # Tính toán và in kết quả
    if operator == '+':
        print(f"{a}+{int(b)}={a + b}")
    elif operator == '-':
        print(f"{a}-{int(b)}={a - b}")
    elif operator == '*':
        print(f"{a}*{int(b)}={a * b}")
    elif operator == '/':
        if b == 0:
            print("Không thể chia cho 0!")
        else:
            print(f"{a}/{int(b)}={a / b}")
    else:
        print("Toán tử không hợp lệ!")

    # Hỏi người dùng có muốn tiếp tục tính toán hay không
    choice = input("Tiep tuc:")
    if choice.lower() == 't':
        break
