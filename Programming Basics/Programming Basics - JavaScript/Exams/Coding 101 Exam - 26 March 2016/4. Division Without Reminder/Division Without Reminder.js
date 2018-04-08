function checkDivisionWithoutReminder(args) {
    let n = Number(args[0]);

    let countTwo = 0;
    let countThree = 0;
    let countFour = 0;

    for (var i = 1; i <= n; i++) {
        let number = Number(args[i]);

        if (number % 4 == 0) {
            countFour++;
        }
        if (number % 3 == 0) {
            countThree++;
        }
        if (number % 2 == 0) {
            countTwo++;
        }
    }

    let divideTwo = (countTwo * 100) / n;
    let divideThree = (countThree * 100) / n;
    let divideFour = (countFour * 100) / n;

    console.log(`${divideTwo.toFixed(2)}%`);
    console.log(`${divideThree.toFixed(2)}%`);
    console.log(`${divideFour.toFixed(2)}%`);
}

/* Uncomment to test:
checkDivisionWithoutReminder(["10", "680", "2", "600", "200", "800", "799", "199", "46", "128", "65"]);
checkDivisionWithoutReminder(["3", "3", "6", "9"]);
    */