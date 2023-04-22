import random

numbers = random.sample(range(1, 50), 6)
numbers.sort()

print("Ve so cua ban la: ",end="")
for n in numbers:
    print(n,end=" ")
# print()
# print(numbers)

# import random

# numbers = [random.randint(1, 9) for _ in range(6)]
# numbers = ''.join(str(num) for num in numbers)
# print(numbers)
