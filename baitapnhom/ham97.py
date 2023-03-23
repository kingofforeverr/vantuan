import random

from Bai94 import tao_pasword
from Bai96 import checkpass

def main():
    test = 0
    while True:
        password = tao_pasword()
        test += 1
        if checkpass(password):
            print("Mật khẩu tốt:", password)
            print("Số lần thử:", test)
            break


if __name__ == '__main__':
    main()
