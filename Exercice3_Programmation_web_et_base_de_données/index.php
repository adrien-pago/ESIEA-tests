<!-- Valeur de connexion à la base de donnée sont fake pour l'exemple-->
<?php include 'mon-header.php'; ?>
<main>
    <form action="adoption.php" method="GET">
        <label for="espece">Sélectionnez une espèce:</label>
        <select name="espece" id="espece">
            <?php
            try {
                $pdo = new PDO('mysql:host=localhost;dbname=nom_de_la_base', 'utilisateur', 'mot_de_passe');
                $query = $pdo->query('SELECT EspèceID, NomCourant FROM Espece');
                while ($row = $query->fetch()) {
                    echo "<option value='{$row['EspèceID']}'>{$row['NomCourant']}</option>";
                }
            } catch (PDOException $e) {
                die("Erreur : " . $e->getMessage());
            }
            ?>
        </select>
        <button type="submit">Rechercher</button>
    </form>
</main>
</body>
</html>
