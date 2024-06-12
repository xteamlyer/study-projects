########### 1 ###########
class chast():
  def __init__(self, nomerchasti, mesto, vidvoisk, colichestvo, syhpai):
    self.__nomerchasti=nomerchasti
    self.mesto=mesto
    self.vidvoisk=vidvoisk
    self.__colichestvo=colichestvo
    self.__syhpai=syhpai
        
  def add_colichestvo(self, value):
    self.__colichestvo = value
        
  def get_colichestvo(self):
    print(self.__colichestvo)
        
  def info(self):
    print(self.__nomerchasti, self.mesto, self.vidvoisk, self.__colichestvo, self.__syhpai)
    
  @property
  def syhpai(self):
    self.__syhpai = 150

counter = chast(13, "Naryan", "Peka", 130, 150)
counter.get_colichestvo()
counter.syhpai
counter.info()

########### 2 ###########
class Vozrast(Exception):
  def __init__(self, age, minage, maxage):
    self.age = age
    self.minage = minage
    self.maxage = maxage

  def __str__(self):
    return f"Недопустимое значение: {self.age}. " \
           f"Возраст должен быть в диапазоне от {self.minage} до {self.maxage}"

class Person:
  def __init__(self, name, age):
    self.__name = name
    minage = 18
    maxage = 27
    if (minage < age) and (age < maxage):
      self.__age = age
    else:
      raise Vozrast(age, minage, maxage)
  
  def display_info(self):
    print(f"Имя: {self.__name}  Возраст: {self.__age}")

try:
  Danila = Person("Danila", 19)
  Danila.display_info()

  Maxim = Person("Maxim", 15)
  bob.display_info()
except Vozrast as e:
  print(e)
