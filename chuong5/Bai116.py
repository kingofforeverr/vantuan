def pig_latin(word):
    vowels = "ueoai"
    
    # Check if the word starts with a capital letter
    if word[0].isupper():
        ki_tu_dau_viet_hoa = True
        word = word.lower()
    else:
        ki_tu_dau_viet_hoa = False
    
    # Check if the word ends with punctuation
    if word[-1]  in ['.', ',', '!', '?']:
        ends_with_punctuation = True
        punctuation = word[-1] 
        word = word[:-1]
    else:
        ends_with_punctuation = False
    
    # Apply Pig Latin rules
    if word[0] in vowels:
        new_word = word + "way"
    else:
        index = 0
        for letter in word:
            if letter in vowels:
                break
            index += 1
        new_word = word[index:] + word[0:index] + "ay"
    
    # Restore capitalization
    if ki_tu_dau_viet_hoa:
        new_word = new_word.capitalize()
    
    # Restore punctuation
    if ends_with_punctuation:
        new_word += punctuation
    
    return new_word

text = input("Nhap mot cau: ")
words = text.split()

for word in words:
    print(pig_latin(word), end=" ")
