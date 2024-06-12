######### 1 #########
class Cat:
    def __init__(self, name, age):
        self.name = name
        self.age = age
 
    def meow(self):
        print('Мяу!')
 
    def eat(self):
        print('Вискас - лучший деликатес!')
 
    def sleep(self):
        print('Ам слип')
 
    def __str__(self):
        return f'Я кот {self.name}, мне {self.age}'
 
 
cat = Cat('Гарфилд', 3)
print(cat)
cat.eat()
cat.meow()
cat.sleep()

######### 2 #########
year = int(input('Введите год: '))

if year % 4 != 0:
    print('Год не високосный.')

elif year % 100 == 0:
    if year % 400 == 0:
        print('Год високосный.')
    else:
        print('Год не високосный.')
else:
    print('Год високосный.')
    
######### 3 #########
# Вариант Владоса
class Aeroflot():
  def __init__(self, destination, flightNumber, typeOfPlane, timeToTakeOff, weekdays):
    self.destination = destination
    self.flightNumber = flightNumber
    self.typeOfPlane = typeOfPlane
    self.timeToTakeOff = timeToTakeOff
    self.weekdays = weekdays

  def info(self):
    print(self.destination)
    print(self.flightNumber)
    print(self.typeOfPlane)
    print(self.timeToTakeOff)
    print(self.weekdays)

firstPlane = Aeroflot("LED", "1337", "BOEING", 13, "SATURDAY")
secondPlane = Aeroflot("LED", "228", "TU-134", 17, "THURSDAY")
thirdPlane = Aeroflot("UEUE", "905", "AIRBUS", 19, "THURSDAY")
lst = [firstPlane, secondPlane, thirdPlane]

#список рейсов для заданного пункта назначения и списко рейсов для заданной недели
count = 0
d = list(firstPlane.__dict__.keys())
s = list(secondPlane.__dict__.keys())
e = list(thirdPlane.__dict__.keys())
print(d)
userInput = input("Введите пункт назначения:")
for i in range(len(d)):
  if userInput == firstPlane.__dict__[d[i]]:
    count += 1
for i in range(len(s)):
  if userInput == firstPlane.__dict__[s[i]]:
    count += 1
for i in range(len(e)):
  if userInput == firstPlane.__dict__[e[i]]:
    count += 1

print("Количество рейсов: ", count)