function calculateHalfSumOfElement(args) {
    let n = Number(args[0]);
    let sum = 0;
    let max = 0;

    for (let i = 1; i <= n; i++) {
        let num = Number(args[i]);
        if (num > max) {
            max = num;
        }
        sum += num;
    }

    sum -= max;
    if (sum == max) {
        console.log("Yes");
        console.log("Sum = " + sum);
    }

    else {
        console.log("No");
        console.log("Diff = " + Math.abs(max - sum));
    }
}

/* Uncomment to test:
calculateHalfSumOfElement(["7", "3", "4", "1", "1", "2", "12", "1"]);
calculateHalfSumOfElement(["4", "6", "1", "2", "3"]);
calculateHalfSumOfElement(["3", "1", "1", "10"]);
calculateHalfSumOfElement(["3", "5", "5", "1"]);
calculateHalfSumOfElement(["3", "1", "1", "1"]);
    */