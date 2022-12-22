from random import randint
list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]
n = 0
element = 0
Position = 0
while n < 10:
    Position = randint(0, 9)
    element = list[n]
    list[n] = list[Position]
    list[Position] = element
print(list)