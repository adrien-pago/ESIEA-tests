function verifierReponse(choix, elementId) {
    const reponseCorrecte = 2; // Choisir la réponse 2 comme correcte
    var element = document.getElementById(elementId);
    if (choix === reponseCorrecte) {
        alert("Bonne réponse !");
        element.style.backgroundColor = "green"; // Change le fond en vert
    } else {
        alert("Mauvaise réponse !");
        element.style.backgroundColor = "red"; // Change le fond en rouge
    }
    // Désactiver les boutons après une sélection
    document.querySelectorAll("button").forEach(button => {
        button.disabled = true;
    });
}
