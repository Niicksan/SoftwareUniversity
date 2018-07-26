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

            while ($num > 0) {
                if ($num % 2 == 1) {
                    echo $num . " ";
                }

                $num--;
            }
        }
    ?>
</body>
</html>
