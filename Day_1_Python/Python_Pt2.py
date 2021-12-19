import os
THIS_FOLDER = os.path.dirname(os.path.abspath(__file__))
file_location = os.path.join(THIS_FOLDER, 'input.txt')
f = open(file_location)
input = f.read()
inputSplit = input.splitlines()


windowA = 0
windowB = 0
increased = 0
# While i < length - 3
for i in range (len(inputSplit) - 3):
    # 100, 101, 105
    num1 = int(inputSplit[i])
    num2 = int(inputSplit[i + 1])
    num3 = int(inputSplit[i + 2])
    windowA = num1 + num2 + num3

    # 101, 105, 106
    num1 = int(inputSplit[i + 1])
    num2 = int(inputSplit[i + 2])
    num3 = int(inputSplit[i + 3])
    windowB = num1 + num2 + num3

    print(str(windowA) + " " + str(windowB))

    # Compare if A is less than B
    if windowA < windowB:
        increased += 1
    
print(increased)