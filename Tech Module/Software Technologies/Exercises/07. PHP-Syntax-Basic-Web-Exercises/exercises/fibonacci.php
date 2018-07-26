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

        $f0 = 0;
        $f1 = 1;

        echo $f1 . " ";
        for ($i = 0; $i < $num - 1; $i++)
        {
            $fNext = $f0 + $f1;
            $f0 = $f1;
            $f1 = $fNext;

            echo $f1 . " ";
        }
    }
    ?>
</body>
</html>