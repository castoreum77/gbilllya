#Напишите программу, которая будет преобразовывать десятичное число в двоичное
result = '' 
number = int(input('введите число: ')) 
while number > 0:
    result = str(number % 2) + result
    number = number // 2
print(result)