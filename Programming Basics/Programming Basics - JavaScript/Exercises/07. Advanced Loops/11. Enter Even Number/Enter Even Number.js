function enterEvenNumber(args) {
    let i = 0;
    let num = 0;
    while (true) {
        try {
            num = Number(args[i]);
            if (num % 2 == 0)
                break; // even number -> exit from the loop
            else {
                console.log("The number is not even.");
            }
            i++;

        } catch (err) {
            console.log("Invalid number!");
        }
    }
    console.log(`Even number entered: ${num}`);
}

/* Uncomment to test:
enterEvenNumber(["34"]);
enterEvenNumber(["33"]);
enterEvenNumber(["hello"]);
    */