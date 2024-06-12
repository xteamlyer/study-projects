####### 1 ########
print(len(set(input().split())))

####### 2 ########
print(len(set(input().split()) & set(input().split())))

####### 3 ########
n = int(input())
A = set()
for i in range(n):
    S = input().split()
    for elem in S:
        A.add(elem)
print(len(A))

####### 4 ########
lang = []
union = set()
all = set()
for i in range(int(input())):
    m = int(input())
    a = {input() for j in range(m)}
    all.update(a)
    if i == 1:
        union.update(a)
    else:
        union &= a
print(len(union))
print('\n'.join(sorted(union)))
print(len(all))
print('\n'.join(sorted(all)))

####### 5 ########
a = set('1234')
b = set('3456')
c = a | b
print(c)

####### 6 ########

####### 7 ########

####### 8 ########
counter = {}
for i in range(int(input())):
    line = input().split()
    for word in line:
        counter[word] = counter.get(word, 0) + 1
        
max_count = max(counter.values())
most_frequent = [k for k, v in counter.items() if v == max_count]
print(min(most_frequent))

####### 9 ########
from collections import defaultdict
from sys import stdin

clients = defaultdict(lambda: defaultdict(int))
for line in stdin.readlines():
    client, thing, value = line.split()
    clients[client][thing] += int(value)
        
for client in sorted(clients):
    print(client + ':')
    for thing in sorted(clients[client]):
        print(thing, clients[client][thing])
        
####### 10 ########
states = {}
 
for _ in range(int(input())):
    state, *cities = input().split()
    for city in cities:
        states[city] = state
 
print(*(states[input()] for _ in range(int(input()))), sep="\n")
