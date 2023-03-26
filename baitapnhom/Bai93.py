from Bai92 import kiemtrasonguyento
import math

def songuyentotieptheo(n):
    
    if n < 2:
        return 2
    snt = n + 1
    while True:
        if kiemtrasonguyento(snt):
            return snt
        snt += 1


n = int(input("Nhập một số nguyên: "))
t = songuyentotieptheo(n)
print(f"Số nguyên tố đầu tiên lớn hơn {n} là {t}.")
