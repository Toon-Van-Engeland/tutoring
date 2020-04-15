from random import random
def willekeurig_getal(lower, upper):
    if(upper < lower):
        (lower, upper) = (upper, lower)
    verschil = upper - lower
    randomGetal = random() * verschil + lower
    return int(randomGetal)

randomGetal = willekeurig_getal(1,100)
print("Raad het getal tussen 0 en 100")
guess = int(input("Uw gok: "))
while(guess != randomGetal):
    if(guess < randomGetal):
        print("Het getal is groter is dan", guess)
    else:
        print("Het getal is kleiner is dan", guess)
    guess = int(input("Uw volgende gok: "))

print("Correct het getal was", randomGetal)
input()