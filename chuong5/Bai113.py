def format_list(items):
    if len(items) == 0:
        return ''
    elif len(items) == 1:
        return items[0]
    elif len(items) == 2:
        return items[0] + ' and ' + items[1]
    else:
        result = ', '.join(items[:-1]) + ' and ' + items[-1]
        return result
items = []
while True:
    item = input('Nhap mot item: ')
    if item == '':
        break
    items.append(item)

result = format_list(items)
print(result)
