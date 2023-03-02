while True:
    n = int(input())
    if n < 0:
        break
    giaithua = 1
    i = 1
    while i <= n:
        giaithua *= i
        i += 1
    print(f"{giaithua}")
