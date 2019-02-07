# TappointmentToGo

### ÉTELFUTÁR - A feladat

Készítsük el egy ételfutár vállalat rendeléseket kezelő rendszerét ASP.NET Core vagy ASP.NET MVC keretrendszerrel.
* A weblapon egy e-mail cím / jelszó megadásával lehessen regisztrálni, majd sikeres regisztráció után bejelentkezni.
* A weblap főoldalán megjelennek a kategóriák (pl. levesek, pizzák, üdítők). 
* A kategóriát kiválasztva listázódnak a tételek (név és ár kíséretében). 
* Ételek esetén leírás is van. Külön meg vannak jelölve a csípős, illetve vegetáriánus ételek.
* Az eddig funkciók nincsenek bejelentkezéshez kötve. A kosarat és a megrendelést csak bejelentkezés után lehessen kezelni.
* Ételek és italok tetszőleges számban helyezhetőek a kosárba egy adott felső korlátig (20.000 Ft), a felett több terméket nem lehet a kosárba helyezni. A felső korlát konfigurálható legyen.
* Legyen elrejtve egy bug a rendszerben: ha a vásárló több mint egy termék vásárlásával eléri a 10.000 Ft-ot (pl. 9000 Ft-nyi tétel már van a kosarában, de még beválaszt egy 1000 Ft-os tételt), akkor hibával (exception) szálljon el a rendszer.
* A kosár tartalma bármikor megtekinthető, ekkor látszódnak a felvett tételek, illetve látható az összár. Bármely tétel kivehető a kosárból.
* A rendelést törölhetjük, illetve leadhatjuk. Utóbbi esetben meg kell adnunk a nevünket, címünket, illetve telefonszámunkat, majd elküldhetjük a rendelést. A rendelést mentsük az adatbázisba. A rendelés leadása után a kosár üres legyen.

A megoldást verziókezelőn keresztül kérjük leadni.

Adatbázis kapcsolathoz ORM-et használj.

A honlap megfeleljen az alapvető biztonsági követelményeknek (pl cross-site scripting elleni védelmek, megfelelő jelszó policy, konfiguráció, stb).

A kosár termék berakása funkcióra készüljenek unit tesztek.

Tesztadatok a mellékelt SQL-ben találhatók.
