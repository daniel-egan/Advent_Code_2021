import os
THIS_FOLDER = os.path.dirname(os.path.abspath(__file__))
file_location = os.path.join(THIS_FOLDER, 'input.txt')
f = open(file_location)
input = f.read()
inputSplit = input.splitlines()

print(inputSplit)

increased = 0
previous = 0

for i in inputSplit:
    current = int(i)
    increased = increased + (current > previous)
    previous = current
    
print(increased - 1)