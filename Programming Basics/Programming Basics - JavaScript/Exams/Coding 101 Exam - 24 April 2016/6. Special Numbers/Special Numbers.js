function specialNumbers([arg1]) {
    let n = Number(arg1);
    var specialNumber = "";
    for (let d1 = 1; d1 <= 9; d1++) {
        for (var d2 = 1; d2 <= 9; d2++) {
            for (var d3 = 1; d3 <= 9; d3++) {
                for (var d4 = 1; d4 <= 9; d4++) {
                    if (n % d1 == 0 && n % d2 == 0 &&
                        n % d3 == 0 && n % d4 == 0) {
                        specialNumber += `${d1}${d2}${d3}${d4} `;
                    }
                }
            }
        }
    }
    console.log(specialNumber);
}

/* Uncomment to test:
specialNumbers(["3"]);
    */