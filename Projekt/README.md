# Menedżer Treningów Fitness

## Projekt zaliczeniowy z wykorzystaniem wzorca MVC

---

# Spis treści

1. Opis projektu
2. Cel projektu
3. Zastosowane technologie
4. Funkcjonalności aplikacji
5. Role użytkowników
6. Modele danych
7. Struktura projektu
8. Instrukcja uruchomienia
9. Podsumowanie

---

# Opis projektu

**Menedżer Treningów Fitness** jest aplikacją internetową stworzoną w technologii **ASP.NET Core MVC**. Projekt umożliwia zarządzanie ćwiczeniami fitness, tworzenie własnych planów treningowych oraz monitorowanie postępów użytkowników.

Aplikacja została zaprojektowana zgodnie z architekturą **Model-View-Controller (MVC)**, dzięki czemu logika biznesowa, dane oraz interfejs użytkownika są od siebie oddzielone.

Projekt wykorzystuje bazę danych SQLite oraz system uwierzytelniania ASP.NET Identity.

---

# Cel projektu

Celem projektu było stworzenie nowoczesnej aplikacji internetowej umożliwiającej:

- zarządzanie bazą ćwiczeń,
- tworzenie planów treningowych,
- monitorowanie wykonanych ćwiczeń,
- zarządzanie użytkownikami,
- wykorzystanie systemu logowania oraz autoryzacji.

---

# Zastosowane technologie

Projekt został wykonany z wykorzystaniem:

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

---

# Funkcjonalności aplikacji

## Rejestracja i logowanie

Aplikacja umożliwia:

- rejestrację użytkownika,
- logowanie,
- wylogowanie,
- obsługę ról użytkowników.

---

## Panel administratora

Administrator posiada możliwość:

- przeglądania panelu administracyjnego,
- zarządzania ćwiczeniami,
- dodawania nowych ćwiczeń,
- edycji ćwiczeń,
- usuwania ćwiczeń,
- przeglądania szczegółów ćwiczeń,
- przeglądania listy użytkowników,
- wyszukiwania użytkowników,
- przeglądania statystyk systemu.

---

## Zarządzanie ćwiczeniami

Każde ćwiczenie posiada:

- nazwę,
- kategorię,
- poziom trudności,
- czas trwania,
- opis.

Administrator może wykonywać pełny zestaw operacji CRUD:

- Create,
- Read,
- Update,
- Delete.

---

## Panel użytkownika

Użytkownik może:

- przeglądać swój panel,
- dodawać ćwiczenia do planu,
- oznaczać ćwiczenia jako wykonane,
- usuwać niewykonane ćwiczenia,
- ponownie dodawać wykonane ćwiczenia,
- śledzić własne postępy.

---

## Filtrowanie ćwiczeń

Dostępne ćwiczenia mogą być filtrowane według:

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

---

## Ankieta treningowa

Aplikacja zawiera ankietę pomagającą dobrać odpowiedni trening.

Na podstawie odpowiedzi użytkownika system proponuje ćwiczenia zgodne z:

- samopoczuciem,
- preferowanym rodzajem treningu,
- poziomem trudności.

---

## Statystyki

Panel administratora prezentuje między innymi:

- liczbę użytkowników,
- liczbę ćwiczeń,
- liczbę ćwiczeń dodanych do planów,
- liczbę wykonanych ćwiczeń.

---

# Role użytkowników

## Administrator

Administrator może:

- zarządzać ćwiczeniami,
- zarządzać użytkownikami,
- przeglądać statystyki,
- edytować dane,
- usuwać dane.

---

## Użytkownik

Użytkownik może:

- logować się do systemu,
- przeglądać dostępne ćwiczenia,
- filtrować ćwiczenia,
- dodawać ćwiczenia do planu,
- oznaczać ćwiczenia jako wykonane,
- monitorować postępy,
- korzystać z ankiety treningowej.

---

# Modele danych

Projekt wykorzystuje między innymi następujące modele:

## Exercise

Model przechowujący informacje o ćwiczeniu:

- Name
- Category
- DifficultyLevel
- Duration
- Description

---

## UserExercise

Model opisujący ćwiczenia przypisane użytkownikowi:

- User
- Exercise
- IsCompleted
- DateAdded

---

## ApplicationUser

Rozszerzony model użytkownika zawierający między innymi:

- Email
- FullName
- RegisteredAt
- LastLoginAt
- LastLogoutAt

---

# Struktura projektu

Projekt wykorzystuje standardową strukturę ASP.NET Core MVC:

- Controllers
- Models
- Views
- Data
- wwwroot
- Areas
- Migrations

---

# Instrukcja uruchomienia

## 1. Pobranie projektu

```bash
git clone <adres_repozytorium>
```

## 2. Przejście do katalogu projektu

```bash
cd Projekt
```

## 3. Przywrócenie zależności

```bash
dotnet restore
```

## 4. Uruchomienie aplikacji

```bash
dotnet run
```

Po uruchomieniu aplikacja będzie dostępna pod adresem:

```
http://localhost:5015
```

lub

```
https://localhost:7154
```

Adresy zostały skonfigurowane w pliku `launchSettings.json`.

---

# Podsumowanie

Projekt został wykonany zgodnie z architekturą MVC oraz wykorzystuje nowoczesne technologie platformy .NET.

Aplikacja umożliwia zarządzanie ćwiczeniami fitness, obsługę użytkowników oraz monitorowanie postępów treningowych. Zawiera system logowania, podział na role, operacje CRUD, filtrowanie danych oraz estetyczny interfejs użytkownika, dzięki czemu stanowi kompletny projekt zaliczeniowy.- walidacja formularzy.

---

## Panel Administratora

Administrator może:

- przeglądać panel administracyjny,
- zarządzać ćwiczeniami,
- dodawać nowe ćwiczenia,
- edytować ćwiczenia,
- usuwać ćwiczenia,
- wyświetlać szczegóły ćwiczeń,
- przeglądać listę użytkowników,
- wyszukiwać użytkowników,
- sprawdzać statystyki systemu.

---

## Zarządzanie ćwiczeniami

Administrator może dodawać:

- nazwę ćwiczenia,
- kategorię,
- poziom trudności,
- czas trwania,
- opis ćwiczenia.

Dostępne operacje:

- Create
- Read
- Update
- Delete

(CRUD)

---

## Panel użytkownika

Użytkownik może:

- przeglądać własny panel,
- dodawać ćwiczenia do swojego planu,
- oznaczać ćwiczenia jako wykonane,
- przeglądać wykonane ćwiczenia,
- przeglądać niewykonane ćwiczenia,
- filtrować ćwiczenia,
- korzystać z ankiety treningowej.

---

## Filtrowanie ćwiczeń

Użytkownik może filtrować ćwiczenia według:

### kategorii

- Siłowe
- Cardio
- Rozciąganie
- Relaksacyjne
- Mobilność
- Core

### poziomu trudności

- Łatwy
- Średni
- Trudny

---

## Ankieta treningowa

Aplikacja zawiera ankietę pomagającą dobrać odpowiednie ćwiczenia.

Użytkownik wybiera między innymi:

- swoje samopoczucie,
- rodzaj treningu,
- poziom trudności.

Na podstawie odpowiedzi aplikacja proponuje odpowiednie ćwiczenia.

---

## Statystyki

Administrator może zobaczyć między innymi:

- liczbę użytkowników,
- liczbę ćwiczeń,
- liczbę wykonanych ćwiczeń,
- liczbę ćwiczeń dodanych do planów.

---

# Role użytkowników

## Administrator

Posiada pełne uprawnienia do zarządzania aplikacją.

Może:

- dodawać dane,
- edytować dane,
- usuwać dane,
- przeglądać użytkowników,
- zarządzać ćwiczeniami.

---

## User

Może:

- logować się,
- dodawać ćwiczenia,
- wykonywać ćwiczenia,
- śledzić postępy,
- korzystać z filtrów,
- korzystać z ankiety.

---

# Modele danych

Projekt wykorzystuje między innymi następujące modele:

## Exercise

Przechowuje informacje o ćwiczeniu:

- Name
- Category
- DifficultyLevel
- Duration
- Description

---

## UserExercise

Przechowuje informacje o ćwiczeniach przypisanych użytkownikowi:

- User
- Exercise
- IsCompleted
- DateAdded

---

## ApplicationUser

Rozszerzony model użytkownika zawierający między innymi:

- Email
- FullName
- RegisteredAt
- LastLoginAt
- LastLogoutAt

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

## 3. Instalacja zależności

```bash
dotnet restore
```

## 4. Utworzenie bazy danych

```bash
dotnet ef database update
```

## 5. Uruchomienie aplikacji

```bash
dotnet run
```

Po uruchomieniu aplikacja będzie dostępna pod adresem:

```
http://localhost:5000
```

lub

```
https://localhost:7000
```

(zależnie od konfiguracji projektu).

---

# Struktura projektu

Projekt wykorzystuje architekturę MVC:

- **Models** – modele danych,
- **Views** – widoki,
- **Controllers** – logika aplikacji,
- **Data** – baza danych,
- **wwwroot** – pliki statyczne,
- **Areas/Identity** – logowanie i rejestracja.

---

# Podsumowanie

Projekt został wykonany zgodnie z architekturą MVC i zawiera:

- system logowania,
- podział na role,
- zarządzanie ćwiczeniami,
- CRUD,
- filtrowanie,
- wyszukiwanie,
- panel administratora,
- panel użytkownika,
- nowoczesny interfejs graficzny,
- bazę danych SQLite,
- wykorzystanie Entity Framework Core oraz ASP.NET Identity.

Aplikacja spełnia wymagania projektu zaliczeniowego i stanowi kompletny system organizacji treningów fitness.
