output = "*"
for i in range(10):
    print(output)
    output += "*"
print()

output = "@"
space = " "
for i in range(10):
    print( ((10-i) * space) + output)
    output += "@"
print()

output  = "#"
space = " "
for i in range(10):
    print( ((10-i) * space) + output)
    output += "##"
print()

title = "vermenigvuldiging tafel van vijf"
print("-" * len(title))
print(title)
for i in range(1, 11):
    if( i != 10):
        output = str(i) + "  |  " + str(i) + " * 5 = " + str(i * 5);
        spacing = space * ((len(title) - len(output)) // 2)
        print(spacing + output)
    else:
        output = str(i) + " | " + str(i) + " * 5 = " + str(i * 5);
        spacing = space * ((len(title) - len(output))//2)
        print(spacing + output)
print("-" * len(title))

def printTafel(getal):
    getalString = str(getal)
    title = "vermenigvuldiging tafel van " + getalString
    print("-" * len(title))
    print(title)
    for i in range(1, 11):
        if (i != 10):
            output = str(i) + "  |  " + str(i) + " * " + getalString + " = " + str(i * getal);
            spacing = space * ((len(title) - len(output)) // 2)
            print(spacing + output)
        else:
            output = str(i) + "  |  " + str(i) + " * " + getalString + " = " + str(i * getal);
            spacing = space * ((len(title) - len(output)) // 2)
            print(spacing + output)
    print("-" * len(title))

printTafel(7)