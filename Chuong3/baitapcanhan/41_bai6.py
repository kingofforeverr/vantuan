import math

a = float(input())
b = float(input())
c = float(input())

if a > 0 and b > 0 and c > 0 and (a + b > c) and (a + c > b) and (b + c > a):
    if a == b == c:
        print("Tam giac deu")
        
       
    elif a*a == b*b + c*c or b*b == a*a + c*c or c*c == a*a + b*b:
        print("Tam giac vuong")
       
        
    else:
        print("Tam giac loai khac")
       
        
else:
    print("Khong hop le")