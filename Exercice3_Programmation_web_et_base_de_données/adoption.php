<!-- Valeur de connexion à la base de donnée sont fake pour l'exemple-->
<?php
session_start();
if (isset($_GET['espece'])) {
    $_SESSION['espece'] = $_GET['espece'];
}

include 'mon-header.php';
?>

<main>
    <form action="animal.php" method="GET">
        <label for="animal">Sélectionnez un animal:</label>
        <select name="animal" id="animal">
            <?php
            try {
                $pdo = new PDO('mysql:host=localhost;dbname=nom_de_la_base', 'utilisateur', 'mot_de_passe');
                $stmt = $pdo->prepare('SELECT AnimalID, Nom FROM Animal WHERE EspèceID = :especeID AND Disponible = TRUE');
                $stmt->execute(['especeID' => $_SESSION['espece']]);
                while ($row = $stmt->fetch()) {
                    echo "<option value='{$row['AnimalID']}'>{$row['Nom']}</option>";
                }
            } catch (PDOException $e) {
                die("Erreur : " . $e->getMessage());
            }
            ?>
        </select>
        <button type="submit">Adopter</button>
    </form>
</main>
</body>
</html>
