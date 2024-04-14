<!-- Valeur de connexion à la base de donnée sont fake pour l'exemple-->
<?php
session_start();
include 'mon-header.php';

if (isset($_GET['animal'])) {
    $animalID = $_GET['animal'];
    try {
        $pdo = new PDO('mysql:host=localhost;dbname=nom_de_la_base', 'utilisateur', 'mot_de_passe');
        $stmt = $pdo->prepare('SELECT Animal.Nom, Animal.DateNaissance, Espece.Prix FROM Animal JOIN Espece ON Animal.EspèceID = Espece.EspèceID WHERE AnimalID = :animalID');
        $stmt->execute(['animalID' => $animalID]);
        $animal = $stmt->fetch();

        echo "<main><h1>Informations de l'animal</h1>";
        echo "<p>Nom : " . htmlspecialchars($animal['Nom']) . "</p>";
        echo "<p>Date de naissance : " . htmlspecialchars($animal['DateNaissance']) . "</p>";
        echo "<p>Prix : " . htmlspecialchars($animal['Prix']) . "€</p>";
        echo "</main>";
    } catch (PDOException $e) {
        die("Erreur : " . $e->getMessage());
    }
}
?>
</body>
</html>
