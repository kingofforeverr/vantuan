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
