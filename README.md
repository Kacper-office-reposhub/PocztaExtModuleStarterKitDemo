# PocztaExtModuleStarterKitDemo

## Opis Techniczny:
 1. Projekt rozszerzający model danych enova365 dla wersji 2406.2.5
 2. Solucja zawiera wygodny dla programisty skrypt przenoszący plik dll do folderu wskazanego w property Target enova365.exe tj. *`--extpath="C:\SonetaAddons"`*
3. Projekt inicjuje dane podczas konwersji bazy danych w zależności od posiadanej wersji należy dostosować property `versionNumber` w pliku `*.business.xml` oraz prop. `dbversion` w *.dbinit.xm

*Dodawanie i odczyt danych wymaga konfiguracji na rolach operatora.*

## Opis Biznesowy GUI:

- **Zakładka: `Handel | Dokumenty wysłane`** - wskazuje wysłane dokumenty wg filtra definicji dokumentu handlowego
- **Tabela `WiadomoscExt` modelu `PocztaExt`** - wskazuje wiadomości powiązane z dokumentem handlowym
- **Tabela `WydrukWiadomosci` modelu `PocztaExt`** - lista wydruków z uwzględnieniem operatora i definicji dokumentu w widoku danych
