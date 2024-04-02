def compter_non_valides(defauts, index):
    # Condition d'arrêt de la récursion
    if index < 0:
        return 0
    # Compter l'élément actuel s'il est non valide, puis passer à l'élément précédent
    if defauts[index] > 2.0:
        return 1 + compter_non_valides(defauts, index - 1)
    else:
        return compter_non_valides(defauts, index - 1)

# Exemple de tableau de pourcentages de défauts
defauts = [0.8, 2.17, 0.02, 3.5, 4.6, 2.01, 1.99]

# Appel de la fonction avec l'ensemble du tableau pour la récursivité (une fonstion qui s'apelle elle même)
nombre_non_valides = compter_non_valides(defauts, len(defauts) - 1)

print(f"Nombre de composants non valides : {nombre_non_valides}")
