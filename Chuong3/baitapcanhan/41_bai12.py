n = int(input())
# tạo bảng chứa giá trị cần
banggiatri = {
    0: 'A',
    1: 'B',
    2: 'C',
    3: 'D',
    4: 'E',
    5: 'F',
    6: 'G',
    7: 'H',
    8: 'K',
    9: 'L'
}
# tạo biến phụ lưu trữ biến lấy tương ứng
n_str = str(n)
bienphu = ''

for i in n_str:
    bienphu += banggiatri[int(i)]

print(bienphu)