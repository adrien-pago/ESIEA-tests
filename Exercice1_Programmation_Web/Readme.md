Structure des dossiers

quiz-app/
│
├── public/
│   ├── css/
│   │   ├── accueil.css
│   │   ├── formulaire_creation.css
│   │   └── affichage_questions.css
│   │
│   ├── js/
│   │   ├── formulaire_creation.js
│   │   └── affichage_questions.js
│   │
│   └── index.html
│
├── views/
│   ├── accueil.html
│   ├── formulaire_creation.html
│   └── affichage_questions.html
│
└── server.js


Avant de Tester
* Installation d'Express :Exécuter $npm install express dans le répertoire de votre projet.
* Lancement du serveur : Lancer le serveur en exécutant $node server.js à la racine du projet dans /quiz-app puis utiliser http://localhost:3000 pour tester l'application 