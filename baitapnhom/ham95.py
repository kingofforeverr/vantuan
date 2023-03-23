import random
import string

def taobiensoxe():
    # 50% cơ hội để tạo ra biển số cũ
    if random.random() < 0.5:
        # Tạo ba chữ cái in hoa ngẫu nhiên
        chucai = ''.join(random.choices(string.ascii_uppercase, k=3))
        # Tạo ba số ngẫu nhiên
        so = ''.join(random.choices(string.digits, k=3))
        return f'{chucai}{so}'
        
    else:
        # Tạo bốn số ngẫu nhiên
        so = ''.join(random.choices(string.digits, k=4))
        # Tạo ba chữ cái in hoa ngẫu nhiên
        chucai = ''.join(random.choices(string.ascii_uppercase, k=3))
        return f'{so}{chucai}'
        
if __name__ == '__main__':
    n = taobiensoxe()
    print(n)

