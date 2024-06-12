######### 1 #########
# zip()
a = [1,2,3]
b = "xyz"
c = (None, True)

res = list(zip(a, b, c))
print (res)

# reduce()
from functools import reduce
items = [1, 24, 17, 14, 9, 32, 2]
all_max = reduce(lambda a,b: a if (a > b) else b, items)

print (all_max)


######### 2 #########
# Вариант 10

import math

def f(x: float) -> float:
    return x ** 3 - math.cos(math.pi * x)
print(f"y = {f(float(input('x = ')))}")

# Вариант 6
import math

def f(x: float) -> float:
    return 2 ** x + x ** 2 - 1.15
print(f"y = {f(float(input('x = ')))}")

# Вариант 11
import math

def f(x: float) -> float:
    return math.sqrt(x) - math.cos(0.387*x)
print(f"y = {f(float(input('x = ')))}")

######### 3 #########

######### 4 #########
# Вариант 10
# доработат
a = int(input("Введите число 1:"))
b = int(input("Введите число 2:"))
temp1 = a
temp2 = ab
rev = 0
while(n > 0):
    dig = a % 10
    rev = rev * 10 + dig
    a = a // 10
if(temp == rev):
    print("Это палиндром!")
else:
    print("Это не палиндром!")
