file = 'LICENSE.txt'

action = input("Введите от 'a' до 'д': ").lower() #а б а г д

with open(file) as f:
  data = f.readlines()

if action == 'a':
  print(*data[0])
elif action == 'б':
  print(*data[4])
elif action == 'в':
  print(*data[0:4])
elif action == 'г':
  s1, s2 = map(int, input('Введите s1 и s2 через пробел: ').split())
  print(*data[s1-1 : s2-1])
elif action == 'д':
  print(*data)

# O(1) + max (0(1))
# O(1) + max (0(1))
# O(1) + max (0(1))
# O(1) + max (0(n))
# O(1) + max (0(1))
# O(5) + (O(4)+O(n)) => O(1) + O(n) => O(n)