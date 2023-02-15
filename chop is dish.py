"""1"""
# number = int(input())
# if (number >= 10) and (number <= 99) and (number % 2 == 0):
#     print("True")
# else:
#     print("False")

"""2"""
# number = int(input())
# if number > 999:
#     if (number % 10 == number / 1000) and (number % 100 / 10 == number % 1000 / 100):
#         print("True")
# else:
#     print("False")

"""3"""
# x = float(input())
# y = float(input())
# if y > 0:
#     if ((x ** 2 + y ** 2) <= 4) and ((x ** 2 + y ** 2) >= 1):
#         print("1")
#     else:
#         print("0")
# else:
#     print("0")

"""4"""
# x = float(input())
# y = float(input())
# if y > 0:
#     if x < 0:
#         if (x ** 2 + y ** 2) <= 1:
#             print("0")
#         else:
#             print(y)
#     else:
#         if ((x ** 2 + y ** 2) <= 1) and ((x ** 2 + y ** 2) >= 0.09):
#             print("0")
#         else:
#             print(y)
# else:
#     print(y)

"""5"""
# x = float(input())
# y = float(input())
# if (x ** 2 + y ** 2) <= 1:
#     if y >= x:
#         if y >= -x:
#             print(x + y)
# else:
#     print(x - y)

"""6"""
# n = int(input())
# a = float(input())
# b = float(input())
# h = (b - a) / n
# print(f'H = {h}')
# w = a
# for i in range(0, n + 1):
#     w = w + h
#     print(w)

"""7"""
# a = float(input())
# n = int(input())
# s = 1
# for i in range(0, n)
#     s = s * a
# print(s)

"""8"""
# x = int(input())
# if (x < -10) or ((x > -3) and (x < 3)) or (x > 5):
#     print("yesss")
# else:
#     print("noooo")

"""9"""
# x = int(input())
# if ((x >= -10) or (x > -3)) and (x == 3) or (x == 5):
#     print("yesss")
# else:
#     print("noooo")

"""10"""
# s = 1000
# print("Введите действительоное число от 0 до 25:")
# p = float(input())
# if (p > 25) or (p < 0):
#     print("Число не соответсвует диапозону условия")
# else:
#     k = 0
#     while s < 1100:
#         s = s * (1 + p / 100)
#         k += 1
# print(f'Количество месяцев: {k}, итоговый размер вклада: {s}')
