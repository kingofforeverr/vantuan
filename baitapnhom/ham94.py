# # from random import randint

# # MIN_ASCII=33
# # MAX_ASCII=126

# # def randomPassword():
# #     lenght = randint(7,10)
    
# #     pass=""
# #     for i in range(lenght):
# #         randomChar = chr(randint(MIN_ASCII,MAX_ASCII))
# #         pass=pass+randomChar
        
# #     return pass
# # def main():
# #     print("your password is:",randomPassword())
    
# # if __name__=="__main__":
# #     main()
# import random


# def tao_password():
#     # Define the char to choose from
#     lenght =random.randint(7,10)
#     # char = string.ascii_letters + string.digits + string.punctuation
#     char = [chr(i) for i in range(33,127)]

#     # Generate the password
#     password = ''.join(random.choice(char) for i in range(lenght))

#     return password

# def main():
   
    
#     print("Your password is:", tao_password())

# if __name__ == "__main__":
#     main()

# # # password = ''
# #     for i in range(length):
# #         password += chr(random.randint(33, 126))
import random

def tao_pasword():
    
   lenght=random.randint(7,10)
   
   char=[chr(i) for i in range(33,127)]
   
   password =''.join(random.choice(char) for i in range(lenght) )
   
   return password

def main():
    print("Your pass:",tao_pasword())
if __name__=="__main__":
    main()