n = input().split()
x = int(input())

vi_tri = []
for i in range(len(n)):
    if int(n[i]) == x:
        vi_tri.append(str(i+1))

if len(vi_tri) > 0:
    print("\n".join(vi_tri))
else:
    print(0)
