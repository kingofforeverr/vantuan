i=0
while i<9:
    j=0
    while j<9-i-1:
        print(" ",end="")
        j+=1
    k=0
    while k<2*i+1:
        print("*",end="")
        k+=1
    print()
    i+=1