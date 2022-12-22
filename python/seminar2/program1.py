#Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

number = int(input('введите число: '))
summ = 0
a = 0 
while number >= 10: 
    a = number % 10
    summ = summ + a
    number = (number - a) / 10
summ = summ + number
print(summ)