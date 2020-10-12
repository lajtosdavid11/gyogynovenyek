# Megoldás
## Osztály létrehozása
Kétféféle mód közül bármelyik ctrl+. vagy jobb klikk +new item + add
  - 5 tulajdonság
  - public get private set
- 1 konstruktor
- 1 paraméter string 
  - például: Acsalapu;levél;6;8 
  - ;-jellel vannak elválasztva
  - átadott fájlból beolvasott sort:
   - ';' Mentén tagoljuk
   - [0] --> Nev
   - [1] --> resz
   - [2] --> kezd
   - [3] --> Veg
   - [4] --> idotartam
   - idotartam --> számolása (következő pont)
  - 4 db adat 5 tulajdonság?
  - 5. tulajdonság az időtartam ami azt jelenti --> Időtartam
    -  Konstruktorban számoljuk
    -  Számolása vég - kezdet ha a vég nagyobb mint a kezdet
    -  Vég > kezdet akkor  --> vég-kezdet+1 
    -  egyébként --> 12 - vég + kezdet + 1;
 # kezdés
    - Adatok beolvasása és tárolása
  - Listában tároljuk a példányokat
   --- System.IO, streamreader, while
   --- cikluson belül listához hozzáadunk egy új példányt (beolvasott sor a paraméter)
 # 1.feladat
 --- Hány növény van ez a lista count tulajdonság
# 2.feladat
 --- Milyen gyüjthető részek vannak?
    --- megszámolása ezeknek?
    --- adatszerkezet Dictionary<string, int>
    --- 1.Milyenek a gyüjthető részek:
    --- foreach "noveny"
    --- Ha a rész nem kulcs --> akkor adunk hozzá 0-át
    --- Hány db van ezekből
    --- Foreach "noveny"
    ---Ha a "Resz" == Key --> Values++;
foreach
# 3.feladat
    --- maximum kereses --> időtartam alapján
--- Növény(ek) amelyeket a legtöbb ideig szedtek
# 4.feladat
    --- átlag számítás időtartam alapján
--- osszeg valtozo
--- atlga valtozo
--- for végig a noveny-en
--- osszeg += idotartam
--- atlag = szum/count

