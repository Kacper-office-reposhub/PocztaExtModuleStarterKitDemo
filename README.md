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

## Przykładowe zrzuty ekranu

<img width="1021" height="406" alt="SonetaExplorer_J6BtDIA3B5" src="https://github.com/user-attachments/assets/f82b040c-5b0a-4fae-8107-1a2a888c7166" />

<img width="1089" height="170" alt="SonetaExplorer_sJNG7NbvjI" src="https://github.com/user-attachments/assets/4933fadd-86fe-4484-a086-257d3b49ff45" />

<img width="884" height="211" alt="SonetaExplorer_Jqtf0Y2f9Q" src="https://github.com/user-attachments/assets/273fe37f-6365-4e24-b80d-d9f8903dfe54" />
