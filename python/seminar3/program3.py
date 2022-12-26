#Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов, отличной от 0.
my_list = [1.1, 1.2, 3.1, 5, 10.01]
a = 0
max = 0
for i in range (len(my_list)):
    a = (int(abs(my_list[i]) * 100) % 100)
    if a > max and a != 0 :
        max = a
min = max
for i in range (len(my_list)):
    a = (int(abs(my_list[i]) * 100) % 100)
    if a < min and a != 0 :
        min = a
result = (max - min)
print(f'0.{result}')