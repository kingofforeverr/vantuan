import random
import string

def taobiensoxe():
   
    if random.random() < 0.5:
       
        chucai = ''.join(random.choices(string.ascii_uppercase, k=3))
     
        so = ''.join(random.choices(string.digits, k=3))
        return f'{chucai}{so}'
        
    else:
      
        so = ''.join(random.choices(string.digits, k=4))

        chucai = ''.join(random.choices(string.ascii_uppercase, k=3))
        return f'{so}{chucai}'
        
if __name__ == '__main__':
    n = taobiensoxe()
    print(n)

