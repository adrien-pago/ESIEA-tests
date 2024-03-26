const express = require('express');
const path = require('path');
const app = express();

app.use('/css', express.static(path.join(__dirname, 'public/css')));
app.use('/js', express.static(path.join(__dirname, 'public/js')));

app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, 'views/accueil.html'));
});

app.get('/formulaire_creation.html', (req, res) => {
    res.sendFile(path.join(__dirname,
        'views/formulaire_creation.html'));
    });
    
    app.get('/affichage_questions.html', (req, res) => {
        res.sendFile(path.join(__dirname, 'views/affichage_questions.html'));
    });
    
    // Endpoint pour traiter le formulaire de création de questions
    app.get('/create-question', (req, res) => {
        // Récupération des données du formulaire pour les traiter
        console.log(req.query); // Affiche les données soumises dans la console pour le debug
        // rediriger l'utilisateur vers la page d'accueil
        res.redirect('/');
    });
    
    const port = 3000;
    app.listen(port, () => {
        console.log(`Serveur démarré sur http://localhost:${port}`);
    });
    