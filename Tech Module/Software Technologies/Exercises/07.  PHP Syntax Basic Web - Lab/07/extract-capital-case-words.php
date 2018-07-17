<?php
    if (isset($_GET['text'])) {
        $text = $_GET['text'];

        preg_match_all('/\w+/', $text,$words);
        $words = $words[0];

        $upperWords = array_filter($words, function ($word) {
            return strToUpper($word) == $word;
        });
    } 
?>

<form action="">
    <textarea name="text" id=""rows="10"><?= implode(', ', $upperWords) ?></textarea> <br>
    <input type="submit" value="Extract">
</form>
