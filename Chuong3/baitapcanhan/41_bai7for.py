while True:
    n = int(input())
    if n < 0:
        break
    giaithua = 1
    for i in range(1, n+1):
        giaithua *= i
    print(f"{giaithua}")
