class Utilities:
    def sprawdz_anagram(self, slowo1, slowo2):
        slowo1 = slowo1.lower()
        slowo2 = slowo2.lower()

        posortowane1 = sorted(slowo1)
        posortowane2 = sorted(slowo2)

        if posortowane1 == posortowane2:
            return True
        else:
            return False


print("Podaj dwa slowa oddzielone przecinkiem:")
dane = input()

slowa = dane.split(",")
slowo1 = slowa[0]
slowo2 = slowa[1]

utilities = Utilities()
wynik = utilities.sprawdz_anagram(slowo1, slowo2)

print("Wynik to")
print(wynik)
