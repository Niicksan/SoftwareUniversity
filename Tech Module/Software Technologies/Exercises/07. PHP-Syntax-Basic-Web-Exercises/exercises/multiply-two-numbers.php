<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form action="">
        <label for="num1">N: </label><input type="text" name="num1" id="num1">
        <label for="num2">M: </label><input type="text" name="num2" id="num2">
        <input type="submit">
    </form>

    <?php
        if (isset($_GET['num1']) && isset($_GET['num2'])) {
            $num1 = intval($_GET['num1']);
            $num2 = intval($_GET['num2']);

            $result = $num1 * $num2;
            echo $result;
        }
    ?>
</body>
</html>