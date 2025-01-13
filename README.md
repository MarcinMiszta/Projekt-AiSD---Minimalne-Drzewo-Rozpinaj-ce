# Projekt AiSD - Minimalne Drzewo Rozpinające

Aplikacja do wyznaczania minimalnego drzewa rozpinającego z wykorzystaniem algorytmu Kruskala. 

## Cel projektu
Aby nadać praktycznego zastosowania dla algorytmu, aplikacja pomaga wyznaczyć minimalną długość węża potrzebnego do stworzenia systemu nawadniania upraw.

## Funkcjonalności aplikacji
1. **Predefiniowane rodzaje upraw:**
   - Aplikacja zawiera kilka predefiniowanych rodzajów upraw (np. Marchew, Pomidory, Ziemniaki), które można wykorzystać do testowania programu.

2. **Dodawanie i usuwanie upraw:**
   - Użytkownik może dynamicznie dodawać nowe uprawy lub usuwać istniejące.

3. **Dodawanie odległości między uprawami:**
   - Za pomocą selektorów i pola tekstowego użytkownik może wprowadzać odległość między wybranymi uprawami (reprezentującymi krawędzie o określonej wadze w grafie).

4. **Wyznaczanie minimalnego drzewa rozpinającego:**
   - Algorytm Kruskala jest wykorzystywany do obliczenia minimalnego drzewa rozpinającego (MST) dla podanego grafu.
   - Wynik wyświetla minimalną długość potrzebnego węża.

5. **Obsługa grafów niespójnych:**
   - Jeśli uprawy tworzą więcej niż jeden graf rozpinający (graf niespójny), aplikacja wyświetli komunikat informujący, że nie wszystkie uprawy są połączone.

## Przykładowe użycie
1. Uruchom aplikację.
2. Wybierz predefiniowane uprawy lub dodaj nowe.
3. Określ odległości między uprawami.
4. Kliknij "Zatwierdź".
5. Zobacz wyniki, w tym minimalną długość węża.
   - Jeśli graf jest niespójny, pojawi się stosowny komunikat.
