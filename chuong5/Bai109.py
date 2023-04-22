def uoc_so(n):
    uoc = []
    for i in range(1, n):
        if n % i == 0:
            uoc.append(i)
    return uoc
if __name__ == '__main__':
    n = int(input("Nhap vao mot so nguyen duong: "))
    print(f"Cac uoc so cua {n} la: {uoc_so(n)}")

