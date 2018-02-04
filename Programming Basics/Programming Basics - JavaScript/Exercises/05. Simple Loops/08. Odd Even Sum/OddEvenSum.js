function checkOddEvenSum(args) {
    let n = Number(args[0]);

    let evenSum = 0;
    let oddSum = 0;

    for (let i = 1; i <= n; i++) {
        let element = Number(args[i]);
        if (i % 2 == 0) {
            evenSum += element;
        }
        else {
            oddSum += element;
        }
    }

    if (evenSum == oddSum) {
        console.log("Yes, sum = " + evenSum);
    }

    else {
        console.log("No, diff = " + Math.abs(evenSum - oddSum));
    }
}

/* Uncomment to test:
checkOddEvenSum(["4", "10", "50", "60", "20"]);
checkOddEvenSum(["4", "3", "5", "1", "-2"]);
checkOddEvenSum(["3", "5", "8", "1"]);
    */