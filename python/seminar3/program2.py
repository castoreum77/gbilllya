#Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
a = []
n = int(input('введите колличество элементов массива: '))
for i in range (0, n):
    a.append(int(input('введите элемент массива: ')))

result = 0
if n % 2 == 0:
    for i in range (0, n // 2):
        result = a[0 + i] * a[n - i - 1]
        print(result)
else:
    for i in range (0, (n + 1) // 2):
        result = a[0 + i] * a[n - i - 1]
        print(result)