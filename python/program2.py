#Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).
x = int(input('введите координату x: '))
y = int(input('введите координату y: '))
if x == 0 or y == 0:
    print('одна из координат равна нулю, выполнение невозможно')
if x > 0 and y > 0:
    print('1')
elif x > 0 and y < 0:
    print('2')
elif x < 0 and y < 0:
    print('3')
else:
    print('4')