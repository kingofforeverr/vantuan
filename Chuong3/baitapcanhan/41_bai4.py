# Nhập điểm thi của các môn
toan = float(input())
ly = float(input())
hoa = float(input())

# Tính điểm trung bình
dtb = (toan * 2 + ly * 3 + hoa) / 6

# Xếp loại học sinh
if dtb < 3:
    xep_loai = "Kem"
elif dtb < 5:
    xep_loai = "Yeu"
elif dtb < 6:
    xep_loai = "Trung binh"
elif dtb < 7:
    xep_loai = "Trung binh kha"
elif dtb < 8:
    xep_loai = "Kha"
elif dtb < 9:
    xep_loai = "Gioi"
else:
    xep_loai = "Xuat sac"

# In kết quả xếp loại

print(xep_loai)
