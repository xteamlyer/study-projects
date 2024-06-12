class sostav():
  def __init__(self, kolichestvosoldat, familia, rota, dolchnost, godrozdenia, godpostuplenia, vislugaley, nagradi, uchastievmeropriatiah):
    self.familia = familia
    self.rota = rota
    self.dolchnost = dolchnost
    self.godrozdenia = godrozdenia
    self.godpostuplenia = godpostuplenia
    self.vislugaley = vislugaley
    self.nagradi = nagradi
    self.uchastievmeropriatiah = uchastievmeropriatiah
    self.kolichestvosoldat = kolichestvosoldat

  def izmenitkolichestvo(self, value):
    # self.kolichestvosoldat += value
    
    if isinstance(value, int):
      answer = self.kolichestvosoldat + value
    elif isinstance(value, str):
      answer = "Введите другое число:"
    else:
      answer = "Ошибка"
    #for x in value:
    # answer = answer + x
    print(answer)

s1 = sostav(100,"Василий", 11, "Пупкин", 2022, 2022, 0, 0, 0)
s2 = sostav(50,"John", 11, "Doe", 2022, 2022, 0, 0, 0)

s1.izmenitkolichestvo(1)
s2.izmenitkolichestvo([1])
s1.izmenitkolichestvo("Че?")