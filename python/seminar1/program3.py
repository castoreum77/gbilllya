#Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
QuarterNumber= int(input('введите номер четверти: '))
if QuarterNumber == 1:
    print('x = (0; ∞]; y = (0; ∞]')
elif QuarterNumber == 2:
    print('x = (0; ∞]; y = (0; -∞]')
elif QuarterNumber == 3:
    print('x = (0; -∞]; y = (0; -∞]')
elif QuarterNumber == 4:
    print('x = (0; -∞]; y = (0; ∞]')
else:
    print('вы ввели некорректный номер')