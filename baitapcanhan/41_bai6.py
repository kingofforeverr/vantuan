n = input().split(',')

a = [i for i in n if int(i, 2) % 3 == 0]

if not a:
    print()
else:
    output = ','.join(a)
    print(output)