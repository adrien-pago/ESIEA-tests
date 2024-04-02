## Speudo code

Fonction CompterNonValides(defauts: tableau de réels, index: entier) : entier
    Si index < 0 alors
        Retourner 0
    FinSi

    Si defauts[index] > 2 alors
        Retourner 1 + CompterNonValides(defauts, index - 1)
    Sinon
        Retourner CompterNonValides(defauts, index - 1)
    FinSi
FinFonction

## Un fichier nombres_non_valides.py 
Exemple de cette fonction récursive en python