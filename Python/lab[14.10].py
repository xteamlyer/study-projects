# cozdanie klassov (5 wtuk)
class Avtomobili():
    def __init__(self, nazvanieavto, marka, godproizvodstva, color, kategoriya, price):
        self.nazvanieavto = nazvanieavto
        self.marka = marka
        self.godproizvodstva = godproizvodstva
        self.color = color
        self.kategoriya = kategoriya
        self.price = price
    def info(self):
        print(self.nazvanieavto)
        print(self.marka)
        print(self.godproizvodstva)
        print(self.color)
        print(self.kategoriya)
        print(self.price)













class MarkaAvto():
    def __init__(self, nazvaniemarki, stranaproizvoditel, zavodproizvoditel, adres):
        self.nazvaniemarki = nazvaniemarki
        self.stranaproizvoditel = stranaproizvoditel
        self.zavodproizvoditel = zavodproizvoditel
        self.adres = adres
    def info(self):
        print(self.nazvaniemarki)
        print(self.stranaproizvoditel)
        print(self.zavodproizvoditel)
        print(self.adres)










# cozdanie inkapsulyazii

class Sotrudniki():
    def __init__(self, familiya, imya, ot4estvo, staj, zarplata):
        self.__familiya = familiya
        self.__imya = imya
        self.__ot4estvo = ot4estvo
        self.__staj = staj
        self.__zarplata = zarplata

    def add__staj(self, value):
        self.__staj = value

    def get_staj(self):
        print(self.__staj)

    def info(self):
        print(self.__familiya)
        print(self.__imya)
        print(self.__ot4estvo)
        print(self.__staj)
        print(self.__zarplata)

# cozdanie svoistva

@property
def zarplata(self): 
    return self.__zarplata


# cozdanie klassa iskly4eniy (priem na rabotu sotrudnikov)

class Vozrast(Exception):  
    def __init__(self, age, minage, maxage):
        self.age = age  
        self.minage = minage  
        self.maxage = maxage  
 
    def __str__(self):
        return f"Nedopustimoe zna4enie: {self.age}. " \
               f"Vozrast doljen bit v diapasone ot {self.minage} do {self.maxage}"



class Person:
    def __init__(self, name, age):
        self.__name = name

        minage = 18
        maxage = 35
        if (minage < age) and (age < maxage):  
            self.__age = age
        else:                                   
            raise Vozrast(age, minage, maxage)
 
    def display_info(self):
        print(f"Imya: {self.__name}  Vozrast: {self.__age}")

# peregruzka operaciy

    def __call__(self, value):
        self._age = value

try:
    Artem = Person("Artem", 26)
    Artem.display_info()

    Daniil = Person("Daniil", 17)
    Daniil.display_info()

except Vozrast as e: 
    print(e)

counter = Sotrudniki("ivanov", "artem", "malovich", "10", "25000")
counter.get_staj()
counter.info()

# cozdanie dokumentirovaniya

print(Person.__doc__)





















class ProdajaAvto():
    def __init__(self, data, sotrudnik, avtomobil, pokupatel):
        self.data = data
        self.sotrunik = sotrudnik
        self.avtomobil = avtomobil
        self.pokupatel = pokupatel

# cozdanie dekoratora

    def log(func):
        def wrapper(*args, **kwargs):
            print('call func {0}'.format(func.__name__), args, kwargs)
            func(*args, **kwargs)
            return wrapper

    def info(self):
        print(self.data)
        print(self.sotrunik)
        print(self.avtomobil)
        print(self.pokupatel)





 







class Pokupateli():
    def __init__(self, familiya, imya, ot4estvo, pasportniedannie, adres, gorod, vozrast, pol):
        self.familiya = familiya
        self.imya = imya
        self.ot4estvo = ot4estvo
        self.pasportniedannie = pasportniedannie
        self.adres = adres
        self.gorod = gorod
        self.vozrast = vozrast
        self.pol = pol
        super(Pokupateli, self).__init_(pasportniedannie)
        self.skidki = Skidki(name, surname)













# cozdanie novogo classa i privyzka classov

class Skidki(object):
    def __init__(self, name, surname):
        self.name = name
        self.surname = surname 








    
    













# razrabotka modulnogo testirovaniya

import unittest
from Python4lab import Pokupateli


class TestPokupateli(unittest.TestCase):
    def setUp(self):
        self.pok = Pokupateli
unittest.main()
