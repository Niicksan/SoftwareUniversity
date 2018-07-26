<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form action="">
        <label for="num">N: </label><input type="text" name="num" id="num">
        <input type="submit">
    </form>

    <?php
    if (isset($_GET['num'])){
        $num = intval($_GET['num']);
        $num *= 2;
        echo $num;
    }
    ?>
</body>
</html>