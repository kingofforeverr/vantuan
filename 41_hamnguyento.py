def LaSoNguyenTo(x):
    if x < 2:
        return False
    for i in range(2, int(x**0.5) + 1):
        if x % i == 0:
            return False
    return True

def SoHopLe(x):
    if x <= 1:
        return True
    else:
        return False

def NhapVaDem():
    count=0
    while True:
        x=int(input())
        if SoHopLe(x):
            break
        if LaSoNguyenTo(x):
            count+=1
    return count

def InKQ(kq):
    print("Co", kq, "so nguyen to")

print("Nhap day so:")
kq = NhapVaDem()
InKQ(kq)
