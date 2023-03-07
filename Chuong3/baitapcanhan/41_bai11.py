soduong = 0
soam = 0

while True:
    num = int(input())
    
    if num == 0:
        break
    
    if num > 0:
        soduong += 1
    else:
        soam += 1

print(f'{soduong} so duong')
print(f'{soam} so am')
