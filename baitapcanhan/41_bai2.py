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