// Import des modules nécessaires
const express = require('express'); // Express, le framework pour créer le serveur web
const path = require('path'); // Path, un module de Node pour manipuler les chemins de fichiers
const app = express(); // Création d'une instance d'Express pour l'application

app.use('/css', express.static(path.join(__dirname, 'public/css')));// Middleware pour servir les fichiers CSS et JavaScript statiques

app.use('/js', express.static(path.join(__dirname, 'public/js')));// Identique au middleware '/css', mais pour les fichiers JavaScript dans 'public/js'

app.get('/', (req, res) => {// Route pour la page d'accueil
 
    res.sendFile(path.join(__dirname, 'views/index.html')); // Envoie le fichier index.html comme réponse au client
 
});
app.get('/formulaire_creation.html', (req, res) => {// Route pour le formulaire de création de question
    res.sendFile(path.join(__dirname, 'views/formulaire_creation.html'));
});

app.get('/affichage_questions.html', (req, res) => {// Route pour la page d'affichage des questions
    res.sendFile(path.join(__dirname, 'views/affichage_questions.html'));
});

// Endpoint pour traiter le formulaire de création de questions
app.get('/create-question', (req, res) => {// Fonction appelée lors d'une requête GET vers '/create-question' 
    console.log(req.query); // Affiche les données du formulaire soumis dans la console, mais on pourrait lles sauvegarder dans une base de données ou un fichier
    res.redirect('/'); // Redirige le client vers la page d'accueil après le traitement
});

// Configuration du port et démarrage du serveur
const port = 3000; // Port sur lequel le serveur va écouter
app.listen(port, () => {
    console.log(`Serveur démarré sur http://localhost:${port}`);   // Affiche un message dans la console pour indiquer que le serveur a démarré
});
