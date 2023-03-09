import math

def nhap():
    print("nhap 3 so nguyen:")
    a = int(input("a="))
    b = int(input("b="))
    c = int(input("c="))
    return a, b, c

def giaipt(a, b, c):
    if a == 0:
        if b == 0:
            if c == 0:
                print("Phuong trinh vo so nghiem")
            else:
                print("Phuong trinh vo nghiem")
        else:
            x = -c / b
            print("Phuong trinh co nghiem duy nhat")
            print("x =", x)
    else:
        delta = b ** 2 - 4 * a * c
        if delta > 0:
            x1 = (-b + math.sqrt(delta)) / (2 * a)
            x2 = (-b - math.sqrt(delta)) / (2 * a)
            print("Phuong trinh co hai nghiem")
            print(f'x1={x1}')
            print(f'x2={x2}')
        elif delta == 0:
            x = -b / (2 * a)
            print("Phuong trinh co nghiem kep")
            print(f'x1=x2={x}')
        else:
            print("Phuong trinh vo nghiem")

def inkq(x1, x2):
    print("Nghiem cua phuong trinh la:")
    print("x1 =", x1)
    print("x2 =", x2)

a, b, c = nhap()
giaipt(a, b, c)
