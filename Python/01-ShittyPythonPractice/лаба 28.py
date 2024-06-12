import sqlite3

con = sqlite3.connect("basa2.db")
cursor = con.cursor()

cursor.execute("""CREATE TABLE IF NOT EXISTS SOTRUDNIKI 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                imya TEXT,
                vozrast INTEGER)
        """)

cursor.execute("""CREATE TABLE IF NOT EXISTS ZAKAZI 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                nomer_zakaza INTEGER,
                nomer_avto INTEGER,
                nomer_klienta INTEGER)
        """)

cursor.execute("""CREATE TABLE IF NOT EXISTS AVTO 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                nomer_avto INTEGER,
                marka TEXT)
        """)

cursor.execute("""CREATE TABLE IF NOT EXISTS KLIENTI 
                (id INTEGER PRIMARY KEY AUTOINCREMENT,
                nomer_klienta INTEGER,
                imya TEXT)
        """)

# множественная вставка 

SOTRUDNIKI = [("Artem", 23), ("Nikita", 43), ("Dasha", 52), ("Danya", 19), ("Vlad", 42)]
cursor.executemany("INSERT INTO SOTRUDNIKI (imya, vozrast) VALUES (?, ?)", SOTRUDNIKI)
con.commit()

# получение одной строки 

cursor.execute("SELECT * FROM SOTRUDNIKI")
print(cursor.fetchone())

# множественная вставка

AVTO = [(1, "BMV"), (2, "mercedec"), (3, "rino"), (4, "porshe"), (5, "audi")]
cursor.executemany("INSERT INTO AVTO (nomer_avto, marka) VALUES (?, ?)", AVTO)
con.commit()

# получение части строки 

cursor.execute("SELECT * FROM AVTO")
print(cursor.fetchmany(5))

# обновление данных

cursor.execute("UPDATE SOTRUDNIKI SET imya = 'Nik' WHERE imya = 'Nikita'")
con.commit()

cursor.execute("SELECT * FROM SOTRUDNIKI")
print(cursor.fetchall())


# удаление данных

cursor.execute("DELETE FROM AVTO WHERE marka =?", ("BMV",))
con.commit()

cursor.execute("SELECT * FROM AVTO")
print(cursor.fetchmany(4))



