############### 1 #################
y = int ( input ('введите курс доллар в рублях :'))
for i in range (1, 20):
    p = i * y
    print (p)
    
############### 2 #################
for i in range(1, 10):
    for j in range(1, 10):
        print(f' {i * j:4}', end=' ')
    print()

############### 3 #################
a = int(input())
b = int(input())
s = 0
i = a
while i<=b:
    s+=i*i
    i+=1
print(s)

############### 4 #################
n = int(input())
x = str()
while n:
    x += str(n%10)
    n //= 10
print(x)


############### 5 #################
n = int(input())
s = 0
res = 1

for i in range (1, n+1):
   res *= i
   s = s + res

print(s)

############### 6 #################
lst = [-1,-2,-3,-5,-6,-7,-7,9,7,4,9]
count = 0
index = 0
while(lst[index]<0):
   count+=1
   index+=1
print(count)

############### 7 #################
fib1 = fib2 = 1
 
n = int(input())
 
print(fib1, fib2, end=' ')
 
for i in range(2, n):
    fib1, fib2 = fib2, fib1 + fib2
    print(fib2, end=' ')
    
############### 8 #################
n = list(input('Введите n: '))
print(n.count(min(n)))

############### 9 #################
n, f, s = map(float, input('n, f, s = ').split())
if s != 0:
    if n == f:
        print('Нет')
    else:
        if s<0:
            f, n = n, f
            s = abs(s)
        while f<n:
            f += s
        print('Да' if n == f else 'Нет')
else:
    print('Да' if n == f else 'Нет')


############### 10 #################
dig = input('Введите число:\n')
spisok = list(dig)
 
max1 =max(spisok)
min1 =min(spisok)
 
print('Максимальная цифра =', max1)
print('Минимальная цифра =', min1)
 
poz1=spisok.index(max1)
poz2=spisok.index(min1)
 
if poz1<poz2:
    print('Левее находится максимальная цифра =', max1)
else:
    print('Левее находится минимальная цифра =', min1 )

############### 11 #################
from math import *
f = int(input("Введите факториал числа n:"))
for n in range(1,f+1):
    if(n==f):
        print("Текст")
        break
    if factorial(n) == f:
        print(n)
        break
 
############### 12 #################
n = int(input())
money = []
money_range = sorted([1, 2, 4, 8, 16, 32, 64], reverse=True)

for i in range(0, len(money_range)):
  if n // money_range[i] != 0:
    num = n // money_range[i]
    for j in range(0, num):
      money.append(money_range[i])
      n -= money_range[i]
    else:
      continue
      
print(*money)

############### 13 #################
for b in range (1, 100//10+1):
    for k in range(1, 100//5+1):
        t = 100-b-k
        if b*10+k*5+t*0.5 == 100:
            print("быки:", b, "коровы:", k, "телята:", t);

############### 14 #################
def hto(x, y):
    if y == 0:
        return 1
    p = hto(x, y // 2)
    p *= p
    if y % 2:
        p *= x
    return p
 
def ladno() :
    n = int(input())
    res = 0
    for i in range(1, n + 1) :
        res += hto(i, i)
    print(res)
    
ladno()
