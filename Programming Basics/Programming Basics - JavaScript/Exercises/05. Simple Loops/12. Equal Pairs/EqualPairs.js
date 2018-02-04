function equalPairsOrNot(args) {
    let n = Number(args[0]);

    let previousPairSum = 0;
    let currentPairSum = 0;
    let difference = 0;
    let biggestdifference = 0;

    for (let i = 1; i <= n; i++) {
        let firstNumber = Number(args[1]);
        let secondNumber = Number(args[2]);

        if (i == 1) {
            previousPairSum = firstNumber + secondNumber;
        }

        else {
            currentPairSum = firstNumber + secondNumber;
            difference = Math.abs(currentPairSum - previousPairSum);

            if (difference > biggestdifference) {
                biggestdifference = difference;
            }

            previousPairSum = currentPairSum;
        }
    }

    if (biggestdifference == 0) {
        console.log(`Yes, value=${previousPairSum}`);
    }
    else {
        console.log(`No, maxdiff=${biggestdifference}`);
    }
}

equalPairsOrNot(["3", "1", "2", "0", "3", "4", "-1"]);
equalPairsOrNot(["4", "1", "1", "3", "1", "2", "2", "0", "0"]);
equalPairsOrNot(["2", "-1", "0", "0", "-1"]);
equalPairsOrNot(["2", "1", "2", "2", "2"]);