
import random

def tao_pasword():
    
   lenght=random.randint(7,10)
   
   char=[chr(i) for i in range(33,127)]
   
   mat_khau =''.join(random.choice(char) for i in range(lenght) )
   
   return mat_khau

def main():
    print("Your pass:",tao_pasword())
if __name__=="__main__":
    main()