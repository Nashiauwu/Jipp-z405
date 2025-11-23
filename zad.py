samogloski = ["a", "ą", "e", "ę", "i", "o", "u", "y",
    "A", "Ą", "E", "Ę", "I", "O", "U", "Y"]
spolgloski = ["b", "c", "ć", "d", "f", "g", "h", "j", "k", "l", "ł", "m", "n", "ń",
    "p", "r", "s", "ś", "t", "w", "z", "ź", "ż", "q", "x", "v",
    "B", "C", "Ć", "D", "F", "G", "H", "J", "K", "L", "Ł", "M", "N", "Ń",
    "P", "R", "S", "Ś", "T", "W", "Z", "Ź", "Ż", "Q", "X", "V"]

slowo = input("Podaj słowo: ")

liczba_samoglosek = 0
liczba_spolglosek = 0

for znak in slowo:
    if znak in samogloski:
        liczba_samoglosek += 1
    elif znak in spolgloski:
        liczba_spolglosek += 1

print("liczba samoglosek")
print(liczba_samoglosek)
print("liczba spolglosek")
print(liczba_spolglosek)