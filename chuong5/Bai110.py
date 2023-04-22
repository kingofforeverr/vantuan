
# def kiemtrasohoanhao():

#     A=[]
#     for i in range(1,n):
#         if n% i==0:
#             A.append(i)
        
#     total=0
#     for d in A:
#         total=total+d
    
#     if total== n:
#         return True
#     return False
# def main():
#     for n in range(1,1001):
#         if kiemtrasohoanhao(n):
#             print(f'so {n} la so hoan hao')

# main()
def kiemtrasohoanhao(n):
    A=[]
# n=int(input())
# if n <= 1:
#     print("false")    
        # return False
    for i in range(1, n):
        if n % i == 0:
            A.append(i)
# print(A)
    total = 0
    for d in A:
        total = total + d
    if total == n:
        # print(f'{n} la so hoan hao')
        return True
    else:
    # print(f'{n} k la so hoan hao')
        return False

def main():
    for n in range(1, 1001):
        if kiemtrasohoanhao(n):
            print(f'So {n} la so hoan hao')
        # else:
        #     print(f'{n} khong la so hoan hao')

main()

