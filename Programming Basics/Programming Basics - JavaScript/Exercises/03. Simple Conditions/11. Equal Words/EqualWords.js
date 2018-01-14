function checkTheWords([arg1, arg2]) {
    let firstWord = arg1;
    let secondWord = arg2;

    firstWord = firstWord.toLowerCase();
    secondWord = secondWord.toLowerCase();

    if (firstWord == secondWord) {
        console.log("yes");
    }

    else {
        console.log("no");
    }
}

/* Uncomment to test:
checkTheWords(["Hello", "Hello"]);
checkTheWords(["SoftUni", "softuni"]);
checkTheWords(["beer", "bodka"]);
checkTheWords(["HeLlO", "hELLo"]);
    */