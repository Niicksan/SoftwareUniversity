<!DOCTYPE html>
<html>
<head>
    <title>Color Palette</title>
    <style>
        div {
            display: inline-block;
            width: 50px;
            height: 50px;
            margin: 5px;
        }
    </style>
</head>
<body>
<table>

    <?php
        for($row = 0; $row < 5; $row++) {
            $color = $row * 51;
            for ($col = 1; $col <= 10; $col++) {
                echo "<div style='background-color: rgb($color, $color, $color)'></div>";
                $color+=5;
            }
            echo "<br>";
        }
    ?>

</table>
</body>
</html>