function drawHouse([arg1]) {
    let n = Number(arg1);
    let stars = 1;

    if (n % 2 == 0) {
        stars++;
    }

    for (let row = 1; row <= parseInt((n + 1) / 2); row++) {
        let padding = parseInt((n - stars) / 2);
        console.log("-".repeat(padding) + "*".repeat(stars) + "-".repeat(padding));
        stars += 2;
    }

    for (let row = 1; row <= parseInt(n / 2); row++) {
        console.log("|" + "*".repeat(n - 2) + "|");
    }
}

/* Uncomment to test:
drawHouse(["5"]);
    */