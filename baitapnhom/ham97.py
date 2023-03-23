import random

from ham94 import tao_pasword
from ham96 import checkpass

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
