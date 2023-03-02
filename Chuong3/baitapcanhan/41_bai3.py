x = float(input("Nhap so thuc x: "))
y = float(input("Nhap so thuc y: "))
ch = input("Nhap ky tu ch (+, -, *, /): ")

if ch == "+":
    print(x ,"+",y,"=" ,round(x + y, 1),sep="")
elif ch == "-":
    print(x ,"-",y ,"=" , round(x - y, 1),sep="")
elif ch == "*":
    print( round(x ,"*",y ,"=" ,x * y, 1),sep="")
elif ch == "/":
    if y == 0:
        print("Khong hop le")
    else:
        print(x ,"/",y ,"=" , round(x / y, 1),sep="")
else:
    print("Ky tu khong hop le")
