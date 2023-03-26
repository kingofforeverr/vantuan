import random
import string

def taobiensoxe():
    t=['Q','W','E','R','T','Y','U','I','O','P','A','S','D','F','G','H','J','K','L','Z','X','C','V','B','N','M']
    s=['0','1','2','3','4','5','6','7','8','9']
   
    if random.random() < 0.5:
        
        chucai = ''.join(random.choices(t, k=3))
      
        so = ''.join(random.choices(s, k=3))
        return f'{chucai}{so}'
        
    else:
       
        so = ''.join(random.choices(s, k=4))
        
        chucai = ''.join(random.choices(t, k=3))
        return f'{so}{chucai}'
        
if __name__ == '__main__':
    n = taobiensoxe()
    print(n)

