from random import random

def randomWithEdges(lowerLimit, higherLimit):
    randomgetal = random();
    return int(((higherLimit - lowerLimit) * randomgetal) + lowerLimit)

print(randomWithEdges(12,24))

def positions_of_vowels(inputString):
    for i in range(len(inputString)):
        if(inputString[i] == 'a' or inputString[i] == 'o' or inputString[i] == 'e' or inputString[i] == 'i' or inputString[i] == 'u'):
            print(i, end=" ")

positions_of_vowels("Are there any vowels here?")

def ask_for_input_untill_stop():
    print()
    output = []
    value = input("Geef hier iets van input: ")

    while(value != "end"):
        output.append(value)
        value = input("Geef hier iets van input: ")
    return output

print(ask_for_input_untill_stop())