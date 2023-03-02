n=int(input())


count = 0
for i in range(2, n + 1, 2):
    print(i, end=" ")
    count += 1
    if count == n:
        break
