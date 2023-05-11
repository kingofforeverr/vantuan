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

a=input()