# Menedżer Treningów Fitness

## Projekt zaliczeniowy – ASP.NET Core MVC

---

# Spis treści

1. Opis projektu
2. Zastosowane technologie
3. Funkcjonalności aplikacji
4. Role użytkowników
5. Modele danych
6. Instrukcja uruchomienia
7. Struktura projektu
8. Podsumowanie

---

# Opis projektu

Menedżer Treningów Fitness jest aplikacją internetową stworzoną z wykorzystaniem wzorca architektonicznego **MVC (Model-View-Controller)**.

Celem projektu jest umożliwienie użytkownikom planowania własnych treningów, dodawania ćwiczeń do swojego planu oraz monitorowania postępów. Administrator posiada możliwość zarządzania bazą ćwiczeń oraz użytkownikami systemu.

Projekt został wykonany w technologii **ASP.NET Core MVC** z wykorzystaniem **Entity Framework Core**, **SQLite** oraz systemu uwierzytelniania **ASP.NET Identity**.

---

# Zastosowane technologie

Projekt został wykonany z użyciem:

- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Identity
- SQLite
- Razor Views
- Bootstrap 5
- HTML5
- CSS3
- JavaScript
- C#

---

# Funkcjonalności aplikacji

## Funkcje ogólne

- rejestracja użytkownika,
- logowanie,
- wylogowanie,
- podział na role Administrator oraz User,
- nowoczesny interfejs graficzny,
- responsywny wygląd aplikacji,
- walidacja formularzy.

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
