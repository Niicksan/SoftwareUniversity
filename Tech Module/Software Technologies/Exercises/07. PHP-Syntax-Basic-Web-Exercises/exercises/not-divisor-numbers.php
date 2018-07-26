<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>

    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $divisor = $num;
            while ($divisor > 0) {
                if ($num % $divisor != 0) {
                    echo $divisor . " ";
                }

                $divisor--;
            }
        }
    ?>
</body>
</html>