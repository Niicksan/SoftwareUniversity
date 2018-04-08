function drawFort([arg1]) {
    let n = parseInt(arg1);
    let sign = parseInt(n / 2);
    let mid = (n * 2) - 4 - 2 * parseInt((n / 2));
    if (n < 5) {
        mid = Number(0);
    }

    for (let row = 1; row <= n; row++) {
        let spaces = 2 * sign + mid + 2;

        if (row == 1) {
            console.log("/" + "^".repeat(sign) + "\\" + "_".repeat(mid)
                + "/" + "^".repeat(sign) + "\\");
        }
        else if (row == n - 1) {
            console.log("|" + " ".repeat(sign + 1) + "_".repeat(mid) + " ".repeat(sign + 1) + "|");
        }
        else if (row == n) {
            console.log("\\" + "_".repeat(sign) + "/" + " ".repeat(mid)
                + "\\" + "_".repeat(sign) + "/");
        }
        else {
            console.log("|" + " ".repeat(spaces) + "|");
        }
    }
}

/* Uncomment to test:
drawFort(["8"]);
    */
