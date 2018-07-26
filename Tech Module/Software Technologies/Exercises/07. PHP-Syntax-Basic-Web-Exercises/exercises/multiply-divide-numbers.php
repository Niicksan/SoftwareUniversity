<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form action="">
        <label for="num1">N: </label><input type="text" name="num1" id="num1"> <br>
        <label for="num2">M: </label><input type="text" name="num2" id="num2"> <br>
        <input type="submit">
    </form>

    <?php
        if (isset($_GET['num1']) && isset($_GET['num2'])) {
            $num1 = intval($_GET['num1']);
            $num2 = intval($_GET['num2']);

            $sum = 0;
            if ($num1 <= $num2) {
                $sum =  $num1 * $num2;
            } else {
                $sum = $num1 / $num2;
            }

            echo $sum;
        }
    ?>
</body>
</html>