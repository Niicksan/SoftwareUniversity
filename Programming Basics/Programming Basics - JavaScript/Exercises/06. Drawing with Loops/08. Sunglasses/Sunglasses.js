function drawSunglasses([arg1]) {
    let n = Number(arg1);

    let stars = 2 * n;
    let dashes = (2 * n) - 2;

    for (var row = 1; row <= n; row++) {
        if (row == 1 || row == n) {
            console.log("*".repeat(stars) + " ".repeat(n) + "*".repeat(stars));
        }

        else {
            if (n % 2 == 0) {
                if (row == n / 2) {
                    console.log("*" + "/".repeat(dashes) + "*" + "|".repeat(n) + "*" + "/".repeat(dashes) + "*");
                }
                else {
                    console.log("*" + "/".repeat(dashes) + "*" + " ".repeat(n) + "*" + "/".repeat(dashes) + "*");
                }
            }
            else {
                if (row == parseInt((n / 2) + 1)) {
                    console.log("*" + "/".repeat(dashes) + "*" + "|".repeat(n) + "*" + "/".repeat(dashes) + "*");
                }
                else {
                    console.log("*" + "/".repeat(dashes) + "*" + " ".repeat(n) + "*" + "/".repeat(dashes) + "*");
                }
            }
        }
    }
}

/* Uncomment to test:
drawSunglasses(["5"]);
    */