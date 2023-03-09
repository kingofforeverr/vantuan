def nhap():
    n = int(input("Nhap vao mot so nguyen duong n >= 2: "))
    return n

def inkq(n):
    for i in range(2, n+1, 2):
        print(i, end=" ")
    print()

# Thực hiện chương trình
while True:
    n = nhap()
    inkq(n)
    tieptuc = input("Tiep tuc khong? (k/K de dung): ")
    if tieptuc in ['k', 'K']:
        break
