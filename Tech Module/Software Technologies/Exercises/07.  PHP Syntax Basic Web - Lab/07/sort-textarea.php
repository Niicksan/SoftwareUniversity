<?php
    $sortedLines = "";
    if (isset($_GET['lines'])) {

        $lines = explode("\n", $_GET['lines']);
        $lines = array_map('trim', $lines);

        sort($lines, SORT_STRING);
        $sortedLines = implode("\n",
            array_filter($lines, function ($e) {
                return $e != "";
            })
        );
    }
?>

<form action="">
    <textarea name="lines" id="area" rows="10"><?= $sortedLines ?></textarea> <br>
    <input type="submit" value="Sort">
</form>
