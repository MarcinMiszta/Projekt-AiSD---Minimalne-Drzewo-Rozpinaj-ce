# Projekt AiSD - Minimalne Drzewo Rozpinające

Aplikacja do wyznaczania minimalnego drzewa rozpinającego z wykorzystaniem algorytmu Kruskala.
Aby nadać praktycznego zastosowania dla algorytmu, aplikacja pomaga wyznaczyć minimalną długość węża od stworzenia systemu nawadniania upraw.
W aplikacji znajduję się kilka predefiniowanych rodzajów upraw, które użytkownik może wykorzystać do testowania programu. Można dodawać oraz usuwać uprawy. Za pomocą selektorów i textBoxa można dodać odległość między uprawami, czyli krawędź o danej wadze w grafie.
Za pomocą algorytmu Kruskala program wyznacza minimalne drzewo rozpinające pomiędzy wszystkimi dodanymi uprawami. Jeśli uprawy tworzą więcej niż jeden graf rozpinający, komunikat w oknie wyniku poinformuje użytkownika, że nie wszystkie uprawy są połaczone.
