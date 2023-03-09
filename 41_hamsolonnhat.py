def nhap():
    a = int(input("Nhap a: "))
    b = int(input("Nhap b: "))
    c = int(input("Nhap c: "))
    return a, b, c

def max3(a, b, c):
    max = a
    if b > max:
        max = b
    if c > max:
        max = c
    return max

def inkq(kq):
    print("So lon nhat la:", kq)

a, b, c = nhap()
kq = max3(a, b, c)
inkq(kq)
