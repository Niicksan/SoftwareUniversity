function squareFrame([arg1]) {
    let n = Number(arg1);

    console.log("+ " + "- ".repeat(n - 2) + "+");

    for (let row = 1; row <= n - 2; row++) {
        console.log("| " + "- ".repeat(n - 2) + "|")
    }

    console.log("+ " + "- ".repeat(n - 2) + "+");
}

/* Uncomment to test:
squareFrame(["5"]);
    */


function squareFrames([arg1]) {
    let n = Number(arg1);

    for (let row = 1; row <= n; row++) {
        if (row == 1 || row == n) {
            console.log("+ " + "- ".repeat(n - 2) + "+");
        }
        else {
            console.log("| " + "- ".repeat(n - 2) + "|")
        }
    }
}

/* Uncomment to test:
squareFrames(["4"]);
    */
