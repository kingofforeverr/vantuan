
# x = []
# y = []
# xy = []
# x_squared = []

# originx = float(input('Enter the X part: '))
# originy = float(input('Enter the Y part: '))

# x.append(originx)
# y.append(originy)
# xy.append(originx * originy) 
# x_squared.append(originx ** 2)

# current = float(input('Enter the X part (Enter to end): '))
# while current != '':
#     currentx = float(current)
#     currenty = float(input('Enter the Y part: '))

#     x.append(currentx)
#     y.append(currenty)
#     xy.append(currentx * currenty)
#     x_squared.append(currentx ** 2)
#     current = input('Enter the X part (Enter to end): ')

# sumx = sum(x)
# sumy = sum(y)

# meanx = sumx / len(x)
# meany = sumy / len(y)

# m = sum(xy) - (sumx * sumy / len(x)) / sum(x_squared) - (sumx ** 2 / len(x))

# b = meany - m * meanx

# print('y = {:.2f}x + ({:.1f})'. format(m, b))
# # print(f'{m}x {b}')


# read in the points from the user
# points = []
# while True:
#     x_str = input("Enter the x-coordinate (blank to quit): ")
#     if not x_str:
#         break
#     x = float(x_str)
#     y = float(input("Enter the y-coordinate: "))
#     points.append((x, y))

# # calculate the averages
# x_avg = sum(x for x, y in points) / len(points)
# y_avg = sum(y for x, y in points) / len(points)

# # calculate m and b
# numerator = sum((x - x_avg) * (y - y_avg) for x, y in points)
# denominator = sum((x - x_avg) ** 2 for x, y in points)
# m = numerator / denominator
# b = y_avg - m * x_avg

# # display the line of best fit
# print(f"y = {m:.2f}x + {b:.1f}")

xs = []
ys = []

# read in the coordinates
while True:
    x_str = input("Enter x coordinate: ")
    if x_str == '':
        break
    y_str = input("Enter y coordinate: ")
    xs.append(float(x_str))
    ys.append(float(y_str))

# calculate the line of best fit
n = len(ys)
x_bar = sum(xs) / n
y_bar = sum(ys) / n
m_num = sum([xi*yi for xi,yi in zip(xs,ys)]) - n*x_bar*y_bar
m_den = sum([xi**2 for xi in xs]) - n*x_bar**2
m = m_num / m_den
b = y_bar - m*x_bar

# display the formula for the line of best fit
print(f"y = {m:.2f}x + {b:.2f}")
