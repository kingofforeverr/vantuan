string = input()
hoa = 0
thuong = 0
so = 0
dacbiet = 0

for char in string:
   
    if char.isupper():
        hoa += 1

    elif char.islower():
        thuong += 1
    
    elif char.isdigit():
        so += 1
    
    else:
        dacbiet += 1


print("In hoa:", hoa)
print("In thuong:", thuong)
print("Chu so:", so)
print("Khac:", dacbiet)
