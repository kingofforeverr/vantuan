import math

def kiemtrasonguyento(n):
    """Kiểm tra xem một số nguyên có phải là số nguyên tố hay không."""
    if n < 2:
        return False
    for i in range(2, int(math.sqrt(n)) + 1):
        if n % i == 0:
            return False
    return True
if __name__ == '__main__':
# Chương trình chính
 n = int(input("Nhập một số nguyên: "))
 if kiemtrasonguyento(n):
    print(f"{n} là số nguyên tố.")
 else:
    print(f"{n} không phải là số nguyên tố.")