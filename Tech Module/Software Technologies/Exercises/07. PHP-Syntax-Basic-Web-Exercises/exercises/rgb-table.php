<!DOCTYPE html>
<html>
<head>
    <title>Color Palette</title>
    <style>
        table td {
            width: 50px;
            height: 50px;
            border: 1px solid black;
        }
    </style>
</head>
<body>
        <table>
            <tr>
                <td>Red</td>
                <td>Green</td>
                <td>Blue</td>
            </tr>

            <?php
                for($i = 51; $i <= 255; $i+=51) {
                    echo "<tr>
                        <td style='background-color: rgb($i, 0, 0)'></td>
                        <td style='background-color: rgb(0, $i, 0)'></td>
                        <td style='background-color: rgb(0, 0, $i)'></td>
                    </tr>";
                }
            ?>
        </table>
</body>
</html>