function findMinNumber(args) {
    let n = Number(args[0]);
    let min = Number.POSITIVE_INFINITY;

    for (let i = 1; i <= n; i++) {
        let num = Number(args[i])
        if (num < min) {
            min = num;
        }
    }
    console.log("min = " + min);
}

/* Uncomment to test:
findMinNumber(["2", "100", "99"]);
findMinNumber(["2", "5", "1"]);
findMinNumber(["3", "10", "-20", "-30"]);
findMinNumber(["4", "45", "-20", "7", "99"]);
findMinNumber(["1", "999"]);
    */