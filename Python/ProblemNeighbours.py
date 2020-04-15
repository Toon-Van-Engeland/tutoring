from random import random
def willekeurig_getal(lower, upper):
    if(upper < lower):
        (lower, upper) = (upper, lower)
    verschil = upper - lower
    randomGetal = random() * verschil + lower
    return int(randomGetal)

def neighbours_of_current_index(matrix, i,j):
    output = []
    if(i != 0 and j != 0):
        output.append(matrix[i - 1][j])
        output.append(matrix[i][j - 1])
    elif(i != 0 and j == 0):
        output.append(matrix[i - 1][j])
    elif (i == 0 and j != 0):
        output.append(matrix[i][j - 1])

    if(len(matrix) - 1 != i):
        output.append(matrix[i+1][j])

    if (len(matrix[i]) - 1 != j):
        output.append(matrix[i][j+1])

    return output


randomMatrix = []
for i in range(10):
    list = []
    for j in range(10):
        list.append(willekeurig_getal(1,100))
    randomMatrix.append(list)

for littleList in randomMatrix:
    print(littleList)
print(neighbours_of_current_index(randomMatrix, 1,9))