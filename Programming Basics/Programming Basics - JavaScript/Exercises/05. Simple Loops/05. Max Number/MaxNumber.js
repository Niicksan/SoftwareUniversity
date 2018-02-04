function findMaxNumber(args) {
    let n = Number(args[0]);
    let max = Number.NEGATIVE_INFINITY;

    for (let i = 1; i <= n; i++) {
        let num = Number(args[i])
        if (num > max) {
            max = num; 
        }
    }
    console.log("max = " + max);
}

/* Uncomment to test:
findMaxNumber(["2", "100", "99"]);
findMaxNumber(["2", "5", "1"]);
findMaxNumber(["3", "10", "-20", "-30"]);
findMaxNumber(["4", "45", "-20", "7", "99"]);
findMaxNumber(["1", "999"]);
    */
