function drawButterfly([arg1]) {
    let n = Number(arg1);

    for (let row = 1; row <= n - 2; row++) {
        if (row % 2 == 1) {
            console.log("*".repeat(n - 2) + "\\ " + "/" + "*".repeat(n - 2));
        }
        else {
            console.log("-".repeat(n - 2) + "\\ " + "/" + "-".repeat(n - 2));
        }
    }
    console.log(" ".repeat(n - 1) + "@" + " ".repeat(n - 1));
    for (let row = 1; row <= n - 2; row++) {
        if (row % 2 == 1) {
            console.log("*".repeat(n - 2) + "/ " + "\\" + "*".repeat(n - 2));
        }
        else {
            console.log("-".repeat(n - 2) + "/ " + "\\" + "-".repeat(n - 2));
        }
    }
}

/* Uncomment to test:
drawButterfly(["7"]);
    */


function drawButterffly([arg1]) {
    let n = Number(arg1);

    for (let row = 1; row <= 2 * (n - 2) + 1; row++) {
        if (row <= n - 2) {
            if (row % 2 == 1) {
                console.log("*".repeat(n - 2) + "\\ " + "/" + "*".repeat(n - 2));
            }
            else {
                console.log("-".repeat(n - 2) + "\\ " + "/" + "-".repeat(n - 2));
            }
        }
        else if (row == n - 1) {
            console.log(" ".repeat(n - 1) + "@" + " ".repeat(n - 1));
        }
        else if (row > n - 1) {
            if (row % 2 == 1) {
                console.log("*".repeat(n - 2) + "/ " + "\\" + "*".repeat(n - 2));
            }
            else {
                console.log("-".repeat(n - 2) + "/ " + "\\" + "-".repeat(n - 2));
            }
        }
    }
}

/* Uncomment to test:
drawButterffly(["7"]);
    */