# import re

# def check_password(password):
#     # Kiểm tra độ dài mật khẩu
#     if len(password) < 6 or len(password) > 17:
#         return False
#     # Kiểm tra các yêu tố an toàn của mật khẩu
#     if not re.search("[a-z]", password):
#         return False
#     if not re.search("[0-9]", password):
#         return False
#     if not re.search("[A-Z]", password):
#         return False
#     if not re.search("[$#@]", password):
#         return False
#     return True

# print(check_password("IAmFine"))
import re

password = input()
if len(password) < 6 or len(password) > 17:
    print(False)
elif not re.search("[a-z]", password):
    print(False)
elif not re.search("[0-9]", password):
    print(False)
elif not re.search("[A-Z]", password):
    print(False)
elif not re.search("[$#@]", password):
    print(False)
else:
    print(True)
