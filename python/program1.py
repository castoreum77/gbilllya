#Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

a = int(input('введите день недели '))
if a == 6 or a == 7:
    print('да') 
else:
    print('нет')