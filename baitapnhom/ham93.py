# import math

# def kiemtrasonguyento(n):
#     """Kiểm tra xem một số nguyên có phải là số nguyên tố hay không."""
#     if n < 2:
#         return False
#     for i in range(2, int(math.sqrt(n)) + 1):
#         if n % i == 0:
#             return False
#     return True
# if __name__ == '__main__':
# # Chương trình chính
#  n = int(input("Nhập một số nguyên: "))
#  if kiemtrasonguyento(n):
#     print(f"{n} là số nguyên tố.")
#  else:
#     print(f"{n} không phải là số nguyên tố.")


import math

def kiemtrasonguyento(num):
    """Kiểm tra xem một số nguyên có phải là số nguyên tố hay không."""
    if num <2:
        return False
    for i in range(2, int(math.sqrt(num)) + 1):
        if num % i == 0:
            return False
    return True

def songuyentotieptheo(n):
    """Tìm số nguyên tố đầu tiên lớn hơn một số nguyên n cho trước."""
    if n < 2:
        return 2
    snt = n + 1
    while True:
        if kiemtrasonguyento(snt):
            return snt
        snt += 1

# Chương trình chính
n = int(input("Nhập một số nguyên: "))
t = songuyentotieptheo(n)
print(f"Số nguyên tố đầu tiên lớn hơn {n} là {t}.")
