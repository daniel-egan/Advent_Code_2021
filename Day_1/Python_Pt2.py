import os
THIS_FOLDER = os.path.dirname(os.path.abspath(__file__))
file_location = os.path.join(THIS_FOLDER, 'input.txt')
f = open(file_location)
input = f.read()
inputSplit = input.splitlines()

testInput = ['100', '101', '105', '106', '103', '104', '106', '108', '112', '123', '125', '149']


windowA = 0
windowB = 0
# While i < length - 3
for i in range (len(testInput) - 2):
    num1 = int(testInput[i])
    num2 = int(testInput[i + 1])
    num3 = int(testInput[i + 2])
    print(num1 + num2 + num3)
    
# Add i, i + 1 and i + 2
# Put into window 1

# Increase i by 3
# Add i, i + 1 and i + 2
# Put into window 2

# Compare if A is less than B