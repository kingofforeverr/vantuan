# def token(s):
#     s = s.replace(' ', '')
#     tokens = []
#     i = 0

#     while len(s) > i:
#         if s[i] == '*' or s[i] == '/' or s[i] == '^' or s[i] == '(' or s[i] == ')':
#             tokens.append(s[i])
#             i += 1
#         elif s[i] == '+' or s[i] == '-':
#             if i > 0 and ('9' <= s[i-1] >= '0' or s[i-1] == ')'):
#                 tokens.append(s[i])
#                 i += 1
#             else:
#                 num = s[i]
#                 i += 1

#                 while len(s) > 1 and '9' <= s[i] >= '0':
#                     num += s[i]
#                     i += 1
#                 tokens.append(num)
#         elif '9' <= s[i] >= '0':
#             num = ''
            
#             while len(s) > 1 and '9' <= s[i] >= '0':
#                 num += s[i]
#                 i += 1
#                 tokens.append(num)
#         else:
#             return []
#     return tokens

# def main():
#     s = input('Enter a mathematical expression: ')
#     print('The tokens are: {}'. format(token(s)))

# if __name__ == '__main__':
#     main()


# def tokenList(s):
#     s= s.replace(" ","")
    
#     token=[]
#     i=0
#     while i<len(s):
#         if s[i]=="*" or s[i]=="/" or s[i]=="^" or s[i]=="(" or s[i]==")":
#             token.append(s[i])
#             i+=1
#         elif s[i]=="+" or s[i]=="-":
#             if i>0 and (s[i-1]>="0" and s[i-1]<="9" or s[i-1]==")"):
#                 token.append(s[i])
#                 i+=1
#             else:
#                 num=s[i]
#                 i+=1
                
#                 while i<len(s) and s[i] >="0" and s[i]<="9":
#                     num=num+s[i]
#                     i+=1
#                 token.append(num)
#         elif s[i]>="0" and s[i]<="9":
#             num=""
#             while i<len(s) and s[i]>="0"and s[i]<="9":
#                 num=num+s[i]
#                 i+=1
#             token.append(num)
#         else:
#             return []
#     return token

# def main():
#     exp=input("nhap: ")
#     token= tokenList(exp)
#     print('the token are:',token)

# if __name__=="__main__":
#     main()

import re

def tokenList(s):
    pattern = r'(\d+|\*|/|\+|-|\^|\(|\))'
    return re.findall(pattern, s.replace(' ', ''))

def main():
    exp = input("Nhập chuỗi biểu thức: ")
    tokens = tokenList(exp)
    print("Các token là:", tokens)

if __name__ == "__main__":
    main()
