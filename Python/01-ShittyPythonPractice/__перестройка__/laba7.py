######### 1 #########

with open('file.name') as datfile:
    text = datfile.read()
print(sum(map(int, text.split(None, 2)[: 2])))

######### 2 #########

print('yes'
    if input() in f.read()
    else 'no')

######### 3 #########

with open('file.name') as t:
    print( * (sum(map(int, line.split())) for line in t.readlines()), sep = '\n')

######### 4 #########

file = open('text.txt')

lines = 0
words = 0
symbols = 0

for line in file:
    lines += 1
words += len(line.split())
symbols += len(line.strip('\n'))

print("Lines:", lines)
print("Words:", words)
print("Symbols:", symbols)

######### 5 #########

######### 6 #########

######### 7 #########

######### 8 #########

count = 0
eq = True
with open("file1.txt", "r", encoding = "utf-8") as f1, open("file2.txt", "r", encoding = "utf-8") as f2:
    for a1, a2 in zip(f1, f2):
    count += 1
if a1 != a2:
    eq = False
break
print(f "Нет отличий") if eq
else print(f "Отличается строка {count}")

######### 9 #########

import sys
save_stdin = sys.stdin
sys.stdin = open("in/32.in")

N, P = input().split()
N, P = int(N), int(P)
cnt = [0] * (N - 1)
for i in range(P):
    fam, name, pFrom, pTo = input().split()
pFrom, pTo = int(pFrom), int(pTo)
for p in range(pFrom, pTo):
    cnt[p - 1] += 1

pMin = min(cnt)
for p in range(N - 1):
    if cnt[p] == pMin:
    print("%d-%d" % (p + 1, p + 2))

sys.stdin = save_stdin

######### 10 #########

inFile = open('input.txt', 'r', encoding = 'utf8')
outFile = open('output.txt', 'w', encoding = 'utf8')
k = inFile.readline()
k = int(k)
rez = []
l = inFile.readlines()
for i in l:
    if len(i.split()) == 6: n1, n2, n3, s1, s2, s3 = i.split()
if len(i.split()) == 5: n1, n2, s1, s2, s3 = i.split() if int(s1) >= 40 and int(s2) >= 40 and int(s3) >= 40: sum = int(s1) + int(s2) + int(s3)
else :
    sum = 0 rez.append(sum) rez.sort(reverse = True)
if rez[k] == 0:
    print(0)
elif rez[0] == rez[k]: print(1)
elif rez[k] == rez[k - 1]: print(rez[k - 2])
else :
    print(rez[k - 1]) inFile.close() outFile.close()
