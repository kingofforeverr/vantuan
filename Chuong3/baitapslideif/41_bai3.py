tieu_thu =int(input("Tieu thu="))


if tieu_thu <= 100:
    phi_dien = tieu_thu * 550
elif tieu_thu <= 150:
    phi_dien = 100 * 550 + (tieu_thu - 100) * 750
elif tieu_thu <= 200:
    phi_dien = 100 * 550 + 50 * 750 + (tieu_thu - 150) * 950
else:
    phi_dien = 100 * 550 + 50 * 750 + 50 * 950 + (tieu_thu - 200) * 1350

phi_vat = phi_dien * 0.1
thanh_tien = phi_dien + phi_vat


print("Phai tra={}".format(round(thanh_tien, 2)))
