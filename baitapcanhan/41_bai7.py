import re

input_str = input()

match = re.search(r'\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b', input_str)

if match:
    print(match.group())
else:
    print()
