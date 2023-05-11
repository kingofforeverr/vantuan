# def i_a(s):
#     # Tách chuỗi thành danh sách các số nhị phân
#     n = s.split(',')
    
#     # Lọc các số chia hết cho 3
#     a = [i for i in n if int(i, 2) % 3 == 0]
    
#     # Nếu không có số nào chia hết cho 3 thì in ra màn hình "Output:"
#     if not a:
#         print("Output:")
#     else:
#         # Nối các số chia hết cho 3 lại thành 1 chuỗi và in ra màn hình
#         output_str = ','.join(a)
#         print("Output:", output_str)

# # Test với input là "0110,0010,1001,1010"
# i_a("0110,0010,1001,1010")

# # Test với input là "0100,0010,1010,1000"
# i_a("0100,0010,1010,1000")
# Tách chuỗi thành danh sách các số nhị phân
# n = input("Nhập chuỗi các số nhị phân (phân tách bằng dấu phẩy): ").split(',')

# # Lọc các số chia hết cho 3
# a = [i for i in n if int(i, 2) % 3 == 0]

# # Nếu không có số nào chia hết cho 3 thì in ra màn hình "Output:"
# if not a:
#     print("Output:")
# else:
#     # Nối các số chia hết cho 3 lại thành 1 chuỗi và in ra màn hình
#     output_str = ','.join(a)
#     print("Output:", output_str)
n = input().split(',')

a = [i for i in n if int(i, 2) % 3 == 0]

if not a:
    print()
else:
    output = ','.join(a)
    print(output)