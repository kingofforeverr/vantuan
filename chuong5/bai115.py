# def pig_latin(word):
#     """
#     Chuyển đổi một từ tiếng Anh thành Pig Latin
#     """
#     vowels = "aeiou"
#     # Tìm vị trí của ký tự nguyên âm đầu tiên trong từ
#     for i in range(len(word)):
#         if word[i] in vowels:
#             break
#     # Tạo từ Pig Latin bằng cách di chuyển các ký tự đầu tiên sang cuối từ và thêm "ay"
#         if word[i] not in vowels:
#             pig_latin_word = word[i:] + word[0:i] + "ay"
#         else:
#             pig_latin_word = word[i:] + word[0:i] + "way"
#     return pig_latin_word

# # Nhập một chuỗi từ người dùng
# sentence = input("Nhập một câu tiếng Anh: ")

# # Chuyển đổi câu thành danh sách các từ
# words = sentence.split()

# # Chuyển đổi từng từ thành Pig Latin và nối lại thành một câu mới
# pig_latin_sentence = " ".join([pig_latin(word) for word in words])

# # In kết quả
# print("Pig Latin của câu đã nhập là: " + pig_latin_sentence)
def pig_latin(word):
    vowels = "ueaoi"
    if word[0] in vowels:
        return word + "way"
    else:
        i = 0
        for letter in word:
            if letter in vowels:
                break
            i += 1
        return word[i:] + word[0:i] + "ay"


text = input("Enter a sentence: ")
words = text.split()

for word in words:
    print(pig_latin(word), end=" ")

