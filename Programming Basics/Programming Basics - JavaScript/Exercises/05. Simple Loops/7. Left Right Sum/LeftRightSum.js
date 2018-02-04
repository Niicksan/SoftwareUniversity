function checkLeftAndRightSum(args) {
    let n = Number(args[0]);
    let leftSum = 0;
    let rightSum = 0;

    for (let i = 1; i <= n; i++) {
        leftSum += Number(args[i]);
    }

    for (let i = n + 1; i <= 2 * n; i++) {
        rightSum += Number(args[i]);
    }

    if (leftSum == rightSum) {
        console.log("Yes, sum = " + leftSum);
    }
    else {
        console.log("No, diff = " + Math.abs(rightSum - leftSum));
    }
}

/* Uncomment to test:
checkLeftAndRightSum(["2", "10", "90", "60", "40"]);
checkLeftAndRightSum(["2", "9", "90", "50", "50"]);
    */