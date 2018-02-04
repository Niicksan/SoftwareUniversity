function vowelsSum([arg1]) {
    let string = arg1;
    let sum = 0;

    for (let i = 1; i <= string.length; i++) {
        if (string[i] == 'a') {
            sum += 1;
        }

        else if (string[i] == 'e') {
            sum += 2;
        }

        else if (string[i] == 'i') {
            sum += 3;
        }

        else if (string[i] == 'o') {
            sum += 4;
        }

        else if (string[i] == 'u') {
            sum += 5;
        }
    }

    console.log("Vowels sum = " + sum);
}

/* Uncomment to test:
vowelsSum(["hello"]);
vowelsSum(["hi"]);
vowelsSum(["bamboo"]);
vowelsSum(["beer"]);
    */