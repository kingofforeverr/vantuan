import string
def checkpass(p):
    hoa=False
    thuong=False
    so=False
    
    for ch in p:
        if ch>="A" and ch<="Z":
            hoa=True
        elif ch>="a" and ch<="z":
            thuong=True
        elif ch>="0" and ch<="9":
            so=True
     
    if len(p)>=8 and hoa and thuong and so:
        return True
    return False

def main():
    p=input("Nhập pass ok:")
    if checkpass(p):
        print("Pass ổn đó bro")
    else:
        print('Pass không được tốt lắm đổi đi')
        
if __name__=="__main__":
    main()