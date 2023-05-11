# str = input()

# clean_str = str.strip()
# clean_str = clean_str.lower()
# # Tách các từ trong chuỗi bằng cách chuyển thành danh sách
# ws =clean_str.split()

# # Chuyển đổi chữ cái đầu tiên của từ đầu tiên thành chữ thường, các từ khác thành chữ thường toàn bộ
# ws = [w.capitalize() if i == 0 else w.lower() for i, w in enumerate(ws)]


# # Kết hợp các từ lại thành một chuỗi mới và xóa các ký tự trắng thừa
# clean_str = " ".join(ws)

# clean_str = clean_str.replace(" ,", ",")
# clean_str = clean_str.replace(" .", ".")
# clean_str = clean_str.replace(" :", ":")
# clean_str = clean_str.replace(" ;", ";")

# # Thêm dấu chấm nếu chuỗi không kết thúc bằng dấu câu
# # if not clean_str.endswith((".", "!", "?")):
# #     clean_str += "."

# # In kết quả ra màn hình
# print(clean_str)





# def clean_str(input_str):
#     # Loại bỏ các ký tự trắng ở đầu và cuối chuỗi
#     clean_str = input_str.strip()
    
#     # Chuyển đổi tất cả các ký tự trong chuỗi thành chữ thường
#     clean_str = clean_str.lower()
    
#     # Tách các từ trong chuỗi
#     ws = clean_str.split()
#     # ws = [w.capitalize() if i == 0 else w.lower() for i, w in enumerate(ws)]
    
#     # Chuyển đổi chữ cái đầu tiên của mỗi từ thành chữ hoa
#     capitalized_ws = [w.capitalize() if i == 0 else w.lower() for i, w in enumerate(ws)]
    
#     # Xây dựng lại chuỗi sạch với các từ được cách nhau đúng 1 ký tự trắng
#     clean_str = " ".join(capitalized_ws)
    
#     # Loại bỏ ký tự trắng trước dấu câu
#     clean_str = clean_str.replace(" ,", ",")
#     clean_str = clean_str.replace(" .", ".")
#     clean_str = clean_str.replace(" :", ":")
#     clean_str = clean_str.replace(" ;", ";")
    
    
#     if not clean_str.endswith((".", "!", "?")):
#         clean_str += "."
#     # Trả về chuỗi kết quả
#     return clean_str

# # Yêu cầu người dùng nhập chuỗi ký tự
# input_str = input("Nhập chuỗi ký tự: ")

# # Gọi hàm làm sạch chuỗi và in kết quả ra màn hình
# print(clean_str(input_str))



str = input()

clean_str = str.strip()
clean_str = clean_str.lower()

ws =clean_str.split()

ws = [w.capitalize() if i == 0 else w.lower() for i, w in enumerate(ws)]


clean_str = " ".join(ws)

clean_str = clean_str.replace(" ,", ",")
clean_str = clean_str.replace(" .", ".")
clean_str = clean_str.replace(" :", ":")
clean_str = clean_str.replace(" ;", ";")

print(clean_str)