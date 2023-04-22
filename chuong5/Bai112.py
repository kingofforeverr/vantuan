numbers = []
while True:
    num = input()
    if not num:
        break
    numbers.append(int(num))

average = sum(numbers) / len(numbers)

below_average = []
equal_average = []
above_average = []

for num in numbers:
    if num < average:
        below_average.append(num)
    elif num == average:
        equal_average.append(num)
    else:
        above_average.append(num)
print("Giá trị trung bình:", average)
print("Dưới giá trị trung bình:", below_average)
print("Bằng giá trị trung bình:", equal_average)
print("Lớn hơn giá trị trung bình:", above_average)
# # numbers = []
# while True:
#     user_input = input("Nhập một số (nhập để thoát): ")
#     if user_input == "":
#         break
#     else:
#         numbers.append(float(user_input))

# n = len(numbers)
# if n == 0:
#     print("Không có số nào để tính trung bình.")
# else:
#     mean = sum(numbers) / n
#     print("Trung bình của tất cả các số là:", mean)

#     means_below = []
#     for i in range(n):
#         # mean_i = sum(numbers[:i+1]) / (i+1)
#         print(numbers[:i+1])
#     #     if mean_i < mean:
#     #         means_below.append(mean_i)
#     # if means_below:
#     #     print("Các giá trị trung bình dưới trung bình chung là:", means_below)

#     # means_equal = []
#     # for i in range(n):
#     #     mean_i = sum(numbers[:i+1]) / (i+1)
#     #     if mean_i == mean:
#     #         means_equal.append(mean_i)
#     # if means_equal:
#     #     print("Các giá trị trung bình bằng trung bình chung là:", means_equal)

#     # means_above = []
#     # for i in range(n):
#     #     mean_i = sum(numbers[:i+1]) / (i+1)
#     #     if mean_i > mean:
#     #         means_above.append(mean_i)
#     # if means_above:
#     #     print("Các giá trị trung bình trên trung bình chung là:", means_above)
# def main():
#     # initialize variables
#     total = 0
#     count = 0
#     numbers = []

#     # read input from user
#     while True:
#         try:
#             s = input("Enter a number (or leave blank to stop): ")
#             if not s:
#                 break
#             num = float(s)
#             numbers.append(num)
#             total += num
#             count += 1
#         except ValueError:
#             print("Invalid input, try again")

#     # compute average
#     if count == 0:
#         print("No numbers entered")
#         return
#     avg = total / count

#     # separate values into below, average and above average
#     below_avg = []
#     avg_vals = []
#     above_avg = []
#     for num in numbers:
#         if num < avg:
#             below_avg.append(num)
#         elif num == avg:
#             avg_vals.append(num)
#         else:
#             above_avg.append(num)

#     # print results
#     print("Average:", avg)
#     print("Below average:", below_avg)
#     print("Average values:", avg_vals)
#     print("Above average:", above_avg)

# if __name__ == "__main__":
#     main()
