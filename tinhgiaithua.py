def nhap():
    n = int(input("n="))
    return n
# tính giai thừa
def giaithua(n):
    if n == 0:
        return 1
    else:
        return n * giaithua(n-1)

def inkq(n, X):
    print(f"{n}!={X}")

# Thực hiện chương trình
n = nhap()
X = giaithua(n)
inkq(n, X)
