PI_M4Solutions
==============

Aplikacija za rukovođenje geodetskih tvrtki

INSTUKCIJE ZA USPJEŠNO POKRETANJE APLIKACIJE
--------------------------------------------

1.
Budući da aplikacija radi uz pomoć PostgreSQL baze podataka, treba se skinuti posljednja verzija (9.2 koristimo) sa 
linka:    http://www.oldapps.com/postgresql.php?old_postgresql=8268?download

2.
Nakon instalacije će se automatski instalirati PgAdmin III aplikacija u kojoj i radimo. Da nebi imali problem sa šiframa
u bazi podataka, nađite u direktoriju gdje ste instalirali PostgreSQL data/pg_hba.conf i pokrenite pomoću WordPad-a.
Nađite sve "md5" vrijednosti i zamjenite sa "trust". Sada možete sa bilo kojom šifrom ući u bazu podataka.

3.
U glavnom folderu na gitu se nalazi datoteka "novo.dump" i to je backup testne baze podataka koju koristimo u projektu.
Restore baze podataka se radi na način da u PgAdminu III stisnete desni klik na postgres bazu podataka (automatski se 
napravi prilikom instalacije) te odaberete opciju "Restore..." . Zatim odaberete sljedeće opcije:
a) Format: Directory
b) Directory: lokaciju preuzete baze podataka sa gita
c) Kliknete Restore

4.
Baza podataka je sada uspješno postavljena, ali budući da VisualStudio 2012 ne podržava nativno PostgreSQL bazu podataka,
potrebno je još instalirati adekvatni konektor koji se može preuzeti sa sljedeće stranice:
http://www.download3k.com/Install-dotConnect-Express-for-PostgreSQL.html

5. Uživajte u aplikaciji :)

