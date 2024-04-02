# Dragon Treasure Game

## Description

Le jeu du Trésor du Dragon est une application console écrite en C#. Il simule une quête où un elfe affronte un dragon pour conquérir un trésor.

## Structure du Projet

Le projet est organisé en plusieurs dossiers contenant les classes et énumérations nécessaires pour le jeu.

### Classes

- `Character` : Classe de base pour les personnages du jeu.
- `Elfe` & `Dragon` : Classes dérivées de `Character`, représentant respectivement l'elfe et le dragon.
- `Game` : Contient la logique principale du jeu.
- `Dice` : Représente le dé à 6 faces utilisé dans le jeu.
- `ChanceCard` : Classe de base pour les cartes chance.

### Enums

- `ChanceCardType` : Énumération des types de cartes chance.

### Program.cs

Point d'entrée du jeu, initialise et exécute la logique principale.

## Logique du Jeu

Le jeu simule un affrontement entre un elfe et un dragon sur un plateau de jeu à 31 cases. Le joueur lance un dé pour avancer et peut rencontrer divers événements basés sur les cartes chance.

La victoire est déterminée lorsque l'elfe atteint la case 31 ou épuise toutes ses tentatives de recommencer.
