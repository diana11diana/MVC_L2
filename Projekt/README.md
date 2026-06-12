# 🏋️ Menedżer Treningów Fitness

## Projekt zaliczeniowy wykonany w technologii ASP.NET Core MVC

---

# Spis treści

1. Opis projektu
2. Cel projektu
3. Wykorzystane technologie
4. Architektura projektu
5. Funkcjonalności aplikacji
6. Role użytkowników
7. Moduł Premium
8. AI Fitness Assistant
9. Modele danych
10. Struktura projektu
11. Instrukcja uruchomienia
12. Dodatkowe funkcjonalności
13. Podsumowanie

---

# Opis projektu

**Menedżer Treningów Fitness** jest nowoczesną aplikacją internetową umożliwiającą zarządzanie treningami oraz monitorowanie postępów użytkowników.

Projekt został wykonany z wykorzystaniem wzorca projektowego **Model-View-Controller (MVC)**, dzięki czemu logika biznesowa, warstwa prezentacji oraz dostęp do danych są od siebie oddzielone.

System pozwala użytkownikowi budować własny plan treningowy, wykonywać ćwiczenia, analizować postępy oraz korzystać z inteligentnych rekomendacji treningowych.

Administrator posiada pełny panel zarządzania użytkownikami oraz bazą ćwiczeń.

---

# Cel projektu

Celem projektu było stworzenie kompletnej aplikacji internetowej umożliwiającej:

- zarządzanie bazą ćwiczeń,
- tworzenie własnych planów treningowych,
- monitorowanie postępów,
- zarządzanie użytkownikami,
- wykorzystanie systemu logowania i autoryzacji,
- zastosowanie architektury MVC,
- wykorzystanie relacyjnej bazy danych.

---

# Wykorzystane technologie

Projekt został wykonany z użyciem:

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQLite
- ASP.NET Identity
- Razor Views
- Bootstrap 5
- HTML5
- CSS3
- JavaScript
- LINQ

---

# Architektura projektu

Projekt wykorzystuje wzorzec **MVC (Model-View-Controller)**.

## Model

Odpowiada za przechowywanie danych oraz logikę biznesową.

## View

Odpowiada za interfejs użytkownika oraz prezentację danych.

## Controller

Pośredniczy pomiędzy modelem a widokiem, realizując logikę działania aplikacji.

---

# Funkcjonalności aplikacji

## Rejestracja i logowanie

Aplikacja umożliwia:

- rejestrację użytkownika,
- logowanie,
- wylogowanie,
- autoryzację,
- obsługę ról użytkowników,
- walidację formularzy.

---

## Panel administratora

Administrator może:

- przeglądać panel administracyjny,
- zarządzać ćwiczeniami,
- dodawać nowe ćwiczenia,
- edytować ćwiczenia,
- usuwać ćwiczenia,
- przeglądać szczegóły ćwiczeń,
- zarządzać użytkownikami,
- wyszukiwać użytkowników,
- przeglądać statystyki systemu.

---

## Zarządzanie ćwiczeniami

Każde ćwiczenie posiada:

- nazwę,
- kategorię,
- poziom trudności,
- czas trwania,
- opis,
- informacje o wymaganym sprzęcie,
- instrukcję wykonania.

Administrator wykonuje pełne operacje:

- Create
- Read
- Update
- Delete

(CRUD)

---

## Panel użytkownika

Użytkownik może:

- przeglądać własny panel,
- dodawać ćwiczenia do planu,
- wykonywać ćwiczenia,
- oznaczać ćwiczenia jako wykonane,
- usuwać niewykonane ćwiczenia,
- ponownie dodawać wykonane ćwiczenia,
- śledzić własne postępy,
- analizować statystyki.

---

## Wykonywanie ćwiczeń

Po wybraniu ćwiczenia użytkownik otrzymuje:

- nazwę ćwiczenia,
- poziom trudności,
- czas wykonania,
- liczbę serii,
- liczbę powtórzeń,
- instrukcję wykonania,
- wymagany sprzęt.

Po zakończeniu treningu może oznaczyć ćwiczenie jako wykonane.

---

## Filtrowanie ćwiczeń

Ćwiczenia mogą być filtrowane według:

### kategorii

- Siłowe
- Cardio
- Mobilność
- Core
- Nogi
- Ramiona
- Plecy
- Brzuch
- Rozciąganie
- Relaksacyjne

### poziomu trudności

- Łatwy
- Średni
- Trudny

### statusu

- Wszystkie
- Do wykonania
- Wykonane

System posiada inteligentny mechanizm wyszukiwania — jeżeli nie znajdzie idealnego dopasowania, proponuje najbardziej podobne ćwiczenia.

---

## Ankieta treningowa

Użytkownik może wypełnić ankietę dnia.

System analizuje:

- samopoczucie,
- preferowany rodzaj treningu,
- poziom trudności,
- oczekiwania użytkownika.

Na podstawie odpowiedzi proponowane są najlepiej dopasowane ćwiczenia.

---

# Moduł Premium

Projekt zawiera dodatkowy moduł Premium.

Użytkownik może przejść przez symulację zakupu konta Premium z wyborem metody płatności.

Po aktywacji otrzymuje dostęp do:

- rozszerzonych statystyk,
- inteligentnych rekomendacji,
- panelu Premium,
- planu dnia,
- dodatkowych analiz postępów.

---

# AI Fitness Assistant

Aplikacja zawiera inteligentnego asystenta treningowego.

Asystent prowadzi rozmowę z użytkownikiem i zadaje pytania dotyczące:

- aktualnego samopoczucia,
- celu treningu,
- preferowanego poziomu,
- rodzaju aktywności.

Na podstawie odpowiedzi proponuje najbardziej odpowiednie ćwiczenia.

---

# Statystyki

Panel użytkownika prezentuje między innymi:

- liczbę wszystkich ćwiczeń,
- liczbę wykonanych ćwiczeń,
- liczbę aktywnych ćwiczeń,
- procent ukończenia planu,
- całkowity czas treningów.

Administrator posiada dodatkowo statystyki całego systemu.

---

# Role użytkowników

## Administrator

Posiada pełne uprawnienia do zarządzania aplikacją.

Może:

- zarządzać użytkownikami,
- zarządzać ćwiczeniami,
- dodawać dane,
- edytować dane,
- usuwać dane,
- przeglądać statystyki.

---

## User

Może:

- logować się,
- korzystać z panelu użytkownika,
- filtrować ćwiczenia,
- dodawać ćwiczenia do planu,
- wykonywać ćwiczenia,
- śledzić postępy,
- korzystać z ankiety,
- korzystać z AI Assistant,
- korzystać z modułu Premium.

---

# Modele danych

## Exercise

Przechowuje informacje o ćwiczeniu:

- Name
- Category
- DifficultyLevel
- Duration
- Description
- Equipment
- Instruction

---

## UserExercise

Przechowuje informacje o ćwiczeniach przypisanych użytkownikowi:

- User
- Exercise
- IsCompleted
- AddedAt
- CompletedAt

---

## ApplicationUser

Rozszerzony model użytkownika zawierający:

- Email
- FullName
- RegisteredAt
- LastLoginAt
- LastLogoutAt

---

# Struktura projektu

Projekt wykorzystuje standardową strukturę MVC:

- Controllers
- Models
- Views
- Data
- Areas
- Migrations
- wwwroot

---

# Instrukcja uruchomienia

## 1. Pobranie projektu

```bash
git clone <adres_repozytorium>
```

## 2. Przejście do katalogu

```bash
cd Projekt
```

## 3. Przywrócenie zależności

```bash
dotnet restore
```

## 4. Aktualizacja bazy danych

```bash
dotnet ef database update
```

## 5. Uruchomienie aplikacji

```bash
dotnet run
```

Po uruchomieniu aplikacja będzie dostępna pod adresami:

```
http://localhost:5015
```

lub

```
https://localhost:7154
```

(adresy zgodne z konfiguracją `launchSettings.json`).

---

# Dodatkowe funkcjonalności

Projekt został rozszerzony o funkcje wykraczające poza podstawowe wymagania:

- inteligentny dobór ćwiczeń,
- AI Fitness Assistant,
- moduł Premium,
- symulację zakupu Premium,
- rozbudowane statystyki,
- nowoczesny responsywny interfejs,
- wyszukiwanie użytkowników,
- inteligentne filtrowanie ćwiczeń,
- monitorowanie postępów,
- walidację formularzy,
- estetyczne panele administracyjne i użytkownika.

---

# Podsumowanie

Projekt został wykonany zgodnie z architekturą **ASP.NET Core MVC** oraz dobrymi praktykami programowania aplikacji internetowych.

Aplikacja umożliwia kompleksowe zarządzanie treningami fitness, obsługę użytkowników oraz monitorowanie postępów. Oprócz podstawowych funkcjonalności wymaganych w projekcie zaimplementowano również szereg autorskich rozszerzeń, takich jak moduł Premium, AI Fitness Assistant, inteligentny dobór ćwiczeń oraz rozbudowany system statystyk.

Dzięki wykorzystaniu **ASP.NET Identity**, **Entity Framework Core**, **SQLite** oraz wzorca **MVC**, projekt stanowi kompletną i nowoczesną aplikację internetową spełniającą wymagania projektu zaliczeniowego oraz prezentującą praktyczne zastosowanie technologii platformy .NET.
⸻

Wykorzystane technologie

Projekt został wykonany z użyciem:

* ASP.NET Core MVC
* C#
* Entity Framework Core
* SQLite
* ASP.NET Identity
* Razor Views
* Bootstrap 5
* HTML5
* CSS3
* JavaScript
* LINQ

⸻

Architektura projektu

Projekt wykorzystuje wzorzec MVC (Model-View-Controller).

Model

Odpowiada za przechowywanie danych oraz logikę biznesową.

View

Odpowiada za interfejs użytkownika oraz prezentację danych.

Controller

Pośredniczy pomiędzy modelem a widokiem, realizując logikę działania aplikacji.

⸻

Funkcjonalności aplikacji

Rejestracja i logowanie

Aplikacja umożliwia:

* rejestrację użytkownika,
* logowanie,
* wylogowanie,
* autoryzację,
* obsługę ról użytkowników,
* walidację formularzy.

⸻

Panel administratora

Administrator może:

* przeglądać panel administracyjny,
* zarządzać ćwiczeniami,
* dodawać nowe ćwiczenia,
* edytować ćwiczenia,
* usuwać ćwiczenia,
* przeglądać szczegóły ćwiczeń,
* zarządzać użytkownikami,
* wyszukiwać użytkowników,
* przeglądać statystyki systemu.

⸻

Zarządzanie ćwiczeniami

Każde ćwiczenie posiada:

* nazwę,
* kategorię,
* poziom trudności,
* czas trwania,
* opis,
* informacje o wymaganym sprzęcie,
* instrukcję wykonania.

Administrator wykonuje pełne operacje:

* Create
* Read
* Update
* Delete

(CRUD)

⸻

Panel użytkownika

Użytkownik może:

* przeglądać własny panel,
* dodawać ćwiczenia do planu,
* wykonywać ćwiczenia,
* oznaczać ćwiczenia jako wykonane,
* usuwać niewykonane ćwiczenia,
* ponownie dodawać wykonane ćwiczenia,
* śledzić własne postępy,
* analizować statystyki.

⸻

Wykonywanie ćwiczeń

Po wybraniu ćwiczenia użytkownik otrzymuje:

* nazwę ćwiczenia,
* poziom trudności,
* czas wykonania,
* liczbę serii,
* liczbę powtórzeń,
* instrukcję wykonania,
* wymagany sprzęt.

Po zakończeniu treningu może oznaczyć ćwiczenie jako wykonane.

⸻

Filtrowanie ćwiczeń

Ćwiczenia mogą być filtrowane według:

kategorii

* Siłowe
* Cardio
* Mobilność
* Core
* Nogi
* Ramiona
* Plecy
* Brzuch
* Rozciąganie
* Relaksacyjne

poziomu trudności

* Łatwy
* Średni
* Trudny

statusu

* Wszystkie
* Do wykonania
* Wykonane

System posiada inteligentny mechanizm wyszukiwania — jeżeli nie znajdzie idealnego dopasowania, proponuje najbardziej podobne ćwiczenia.

⸻

Ankieta treningowa

Użytkownik może wypełnić ankietę dnia.

System analizuje:

* samopoczucie,
* preferowany rodzaj treningu,
* poziom trudności,
* oczekiwania użytkownika.

Na podstawie odpowiedzi proponowane są najlepiej dopasowane ćwiczenia.

⸻

Moduł Premium

Projekt zawiera dodatkowy moduł Premium.

Użytkownik może przejść przez symulację zakupu konta Premium z wyborem metody płatności.

Po aktywacji otrzymuje dostęp do:

* rozszerzonych statystyk,
* inteligentnych rekomendacji,
* panelu Premium,
* planu dnia,
* dodatkowych analiz postępów.

⸻

AI Fitness Assistant

Aplikacja zawiera inteligentnego asystenta treningowego.

Asystent prowadzi rozmowę z użytkownikiem i zadaje pytania dotyczące:

* aktualnego samopoczucia,
* celu treningu,
* preferowanego poziomu,
* rodzaju aktywności.

Na podstawie odpowiedzi proponuje najbardziej odpowiednie ćwiczenia.

⸻

Statystyki

Panel użytkownika prezentuje między innymi:

* liczbę wszystkich ćwiczeń,
* liczbę wykonanych ćwiczeń,
* liczbę aktywnych ćwiczeń,
* procent ukończenia planu,
* całkowity czas treningów.

Administrator posiada dodatkowo statystyki całego systemu.

⸻

Role użytkowników

Administrator

Posiada pełne uprawnienia do zarządzania aplikacją.

Może:

* zarządzać użytkownikami,
* zarządzać ćwiczeniami,
* dodawać dane,
* edytować dane,
* usuwać dane,
* przeglądać statystyki.

⸻

User

Może:

* logować się,
* korzystać z panelu użytkownika,
* filtrować ćwiczenia,
* dodawać ćwiczenia do planu,
* wykonywać ćwiczenia,
* śledzić postępy,
* korzystać z ankiety,
* korzystać z AI Assistant,
* korzystać z modułu Premium.

⸻

Modele danych

Exercise

Przechowuje informacje o ćwiczeniu:

* Name
* Category
* DifficultyLevel
* Duration
* Description
* Equipment
* Instruction

⸻

UserExercise

Przechowuje informacje o ćwiczeniach przypisanych użytkownikowi:

* User
* Exercise
* IsCompleted
* AddedAt
* CompletedAt

⸻

ApplicationUser

Rozszerzony model użytkownika zawierający:

* Email
* FullName
* RegisteredAt
* LastLoginAt
* LastLogoutAt

⸻

Struktura projektu

Projekt wykorzystuje standardową strukturę MVC:

* Controllers
* Models
* Views
* Data
* Areas
* Migrations
* wwwroot

⸻

Instrukcja uruchomienia

1. Pobranie projektu

git clone <adres_repozytorium>

2. Przejście do katalogu

cd Projekt

3. Przywrócenie zależności

dotnet restore

4. Aktualizacja bazy danych

dotnet ef database update

5. Uruchomienie aplikacji

dotnet run

Po uruchomieniu aplikacja będzie dostępna pod adresami:

http://localhost:5015

lub

https://localhost:7154

(adresy zgodne z konfiguracją launchSettings.json).

⸻

Dodatkowe funkcjonalności

Projekt został rozszerzony o funkcje wykraczające poza podstawowe wymagania:

* inteligentny dobór ćwiczeń,
* AI Fitness Assistant,
* moduł Premium,
* symulację zakupu Premium,
* rozbudowane statystyki,
* nowoczesny responsywny interfejs,
* wyszukiwanie użytkowników,
* inteligentne filtrowanie ćwiczeń,
* monitorowanie postępów,
* walidację formularzy,
* estetyczne panele administracyjne i użytkownika.

⸻

Podsumowanie

Projekt został wykonany zgodnie z architekturą ASP.NET Core MVC oraz dobrymi praktykami programowania aplikacji internetowych.

Aplikacja umożliwia kompleksowe zarządzanie treningami fitness, obsługę użytkowników oraz monitorowanie postępów. Oprócz podstawowych funkcjonalności wymaganych w projekcie zaimplementowano również szereg autorskich rozszerzeń, takich jak moduł Premium, AI Fitness Assistant, inteligentny dobór ćwiczeń oraz rozbudowany system statystyk.

Dzięki wykorzystaniu ASP.NET Identity, Entity Framework Core, SQLite oraz wzorca MVC, projekt stanowi kompletną i nowoczesną aplikację internetową spełniającą wymagania projektu zaliczeniowego oraz prezentującą praktyczne zastosowanie technologii platformy .NET.
