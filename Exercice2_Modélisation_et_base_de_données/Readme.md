# Exercice 2 : Modélisation et Base de Données

## Modèle Conceptuel des Données (MCD)

### Entités et Associations
- **Client**
  - Attributs : ClientID (clé primaire), Nom, Prénom, Adresse, Email
- **Animal**
  - Attributs : AnimalID (clé primaire), Nom, DateNaissance, Commentaires, Disponible (booléen), EspèceID (clé étrangère), ClientID (clé étrangère nullable)
- **Espèce**
  - Attributs : EspèceID (clé primaire), NomCourant, NomLatin, Description, Prix
- **Adoption**
  - Attributs : AdoptionID (clé primaire), DateRéservation, DateAdoption, Payé (booléen), AnimalID (clé étrangère), ClientID (clé étrangère)

### Relations
- Un Client peut adopter plusieurs Animaux (relation 1-n entre Client et Adoption).
- Un Animal est adopté par un seul Client à la fois (relation 1-1 entre Animal et Adoption avec la possibilité que l'Animal ne soit pas encore adopté).
- Un Animal appartient à une seule Espèce mais il peut y avoir plusieurs Animaux d'une même espèce (relation 1-n entre Espèce et Animal).

### Hypothèses
- Un animal peut être réservé (indiqué par la date de réservation) mais pas encore officiellement adopté (indiqué par la date d'adoption).
- La disponibilité d'un animal est indiquée par un booléen. Si l'animal est adopté, cette valeur est fausse.
- L'adoption est considérée comme payée ou non payée au moment de l'adoption effective.

## Dictionnaire de données
- **Client**
  - ClientID : INT, identifiant unique du client.
  - Nom : VARCHAR, nom du client.
  - Prénom : VARCHAR, prénom du client.
  - Adresse : VARCHAR, adresse du client.
  - Email : VARCHAR, email du client.
- **Animal**
  - AnimalID : INT, identifiant unique de l'animal.
  - Nom : VARCHAR, nom de l'animal.
  - DateNaissance : DATE, date de naissance de l'animal.
  - Commentaires : TEXT, commentaires sur l'animal.
  - Disponible : BOOLEAN, si l'animal est disponible pour adoption.
  - EspèceID : INT, clé étrangère vers l'espèce de l'animal.
  - ClientID : INT, clé étrangère vers le client adoptant (nullable si pas encore adopté).
- **Espèce**
  - EspèceID : INT, identifiant unique de l'espèce.
  - NomCourant : VARCHAR, nom courant de l'espèce.
  - NomLatin : VARCHAR, nom latin de l'espèce.
  - Description : TEXT, description de l'espèce.
  - Prix : DECIMAL, prix d'adoption de l'espèce.
- **Adoption**
  - AdoptionID : INT, identifiant unique de l'adoption.
  - DateRéservation : DATE, date de réservation pour l'adoption.
  - DateAdoption : DATE, date effective de l'adoption.
  - Payé : BOOLEAN, si l'adoption a été payée.
  - AnimalID : INT, clé étrangère vers l'animal adopté.
  - ClientID : INT, clé étrangère vers le client adoptant.

## Modèle Relationnel
- Client(ClientID, Nom, Prénom, Adresse, Email)
- Espèce(EspèceID, NomCourant, NomLatin, Description, Prix)
- Animal(AnimalID, Nom, DateNaissance, Commentaires, Disponible, EspèceID, ClientID)
- Adoption(AdoptionID, DateRéservation, DateAdoption, Payé, AnimalID, *ClientID)

## Requête SQL

**Sélectionner les noms, commentaires et dates de naissance des animaux disponibles à l'adoption :**
```
SELECT Nom, Commentaires, DateNaissance
FROM Animal
WHERE Disponible = TRUE;
```
**Supprimer l'adoption de l'animal dont l'id = 5 :**
```
DELETE FROM Adoption
WHERE AnimalID = 5;
```
**Mettre à jour le statut disponible de l'animal dont l'id = 5 :**
Pour marquer l'animal comme disponible à nouveau, on suppose qu'il était indiqué comme non disponible :
```
UPDATE Animal
SET Disponible = TRUE
WHERE AnimalID = 5;
```

**Sélectionner les animaux de l'espèce "chat" :**
On suppose que le nom courant de l'espèce "chat" est stocké dans la table Espèce :
```
SELECT Animal.Nom
FROM Animal
JOIN Espèce ON Animal.EspèceID = Espèce.EspèceID
WHERE Espèce.NomCourant = 'Chat';
```

**Compter le nombre d'animaux par espèces :**
```
SELECT Espèce.NomCourant, COUNT(Animal.AnimalID) AS NombreAnimaux
FROM Animal
JOIN Espèce ON Animal.EspèceID = Espèce.EspèceID
GROUP BY Espèce.NomCourant;
```




