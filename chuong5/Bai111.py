def tach_chuoi(n):
    n = n.strip("'")
    n = n.replace(',', ' ')
    n = n.replace('.', ' ')
    n = n.replace(':', ' ')
    n = n.replace(';', ' ')
    n = n.replace('!', ' ')
    n = n.replace('"', ' ')
    word = n.split()
    return word
if __name__=='__main__':
    n=input("nhap mot chuoi: ")
    m=tach_chuoi(n)
    print(m)
