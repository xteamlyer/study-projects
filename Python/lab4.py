############### 1 ################
from random import randint
print([randint(163, 190) for i in range(12)])

############### 2 ################
a, p = map(int, input("a, p = ").split())
lst = [a]
for i in range(1, 10):
    lst.append(a+i*p)
print(*lst)

############### 3 ################
x = [1, 2, 3]
for i in reversed(x):
    print(i)
    
############### 4 ################
a = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
print( sum(v for i,v in enumerate(a) if not i%2) - sum(v for i,v in enumerate(a) if i%2))

############### 5 ################
k=[10,10,20,40,35,30,10,10,20,40,35,30,10,10,20,40,35,30,10,10,20,40,35,30,10,10,20,40,35,30,10,20,40,35,30,10,10,20,40,35,30,10]
t=str(sum(k))
print("Общее число учеников ",t)
if len(t)==4 :
    print(" есть четырехзначное число")
else :
    print(" не является четырехзначным числом")

############### 6 ################
def main(l):
    print(*(i for i in l if i[-1] == '0'))
lst = input().split()
main(lst)

############### 7 ################

############### 8 ################
a = [int(i) for i in input().split()]
num_distinct = 1
for i in range(0, len(a) - 1):
    if a[i] != a[i + 1]:
        num_distinct += 1
print(num_distinct)

############### 9 ################
a = [int(i) for i in input().split()]
for i in range(1, len(a), 2):
    a[i - 1], a[i] = a[i], a[i - 1]
print(' '.join([str(i) for i in a]))

############### 10 ###############
a = []
n = int (input())
for i in range(n):
    new_element = int(input())
    a.append(new_element)
print(a)
if n%2==0:
    print(a[n/2: n]+a[0: n/2])
else:
    print('нет')
    
############### 11 ###############
def guests_seating( n, dis ):
    lis = list( range(1, n + 1) )
    bad_pairs = set()
    for e in dis:
        L, de, R = e.partition('-')
        not_frends = set( int(x) for x in R.split(',') )
        for nf in not_frends:
            bad_pairs.add( frozenset( [int(L), nf] ) )
    res = [ [x] for x in lis ]
    flag = True
    while flag:
        flag = False
        for x in res:
            for y in lis:
                if frozenset([x[-1],y]) not in bad_pairs and y not in x:
                    x.append(y)
                    flag = True
                    if len(x) == n:
                        #return x
                        return True
    return False
n = 10
dis = '1-2,4,6,8 3-5,7,9 4-1,2,3 5-2,4 6-3'.split()
print( guests_seating( n, dis ) )

############### 12 ###############

############### 13 ###############
from functools import reduce
 
a = [17,18,19]
b = [['q', 'w', 'e'], ['r', 't'], ['z', 'x', 'c', 'v']]
c = list( reduce(lambda x,y: x+y, b) )
 
print(len(c), min(b, key=len), max(b, key=len), sorted(c))

############### 14 ###############
import math
grades = [5, 4, 5, 3, 2, 5, 4, 3, 5, 5, 4, 2, 2, 3]
print(f'Средний балл: sum(grades) / len(grades)')
print(*grades, sep=';')

############### 15 ###############
print([i for i in range(0, 10001, 3) if not i%7 or not i%9])

############### 16 ###############

############### 17 ###############
a = [[i,10*i] for i in range(1,5)]
print(a)
b = sum(a,[])

############### 18 ###############
print([i**2 if i%2 == 0 else i+2 for i in range(1,21)])
print(b)
