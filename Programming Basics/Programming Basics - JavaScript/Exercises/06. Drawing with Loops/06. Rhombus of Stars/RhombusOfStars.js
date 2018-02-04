function rhombusOfStars([arg1]) {
    let n = Number(arg1);

    for (let row = 1; row <= n; row++) {
        console.log(" ".repeat(n - row) + "* ".repeat(row));
    }
    for (let row = n - 1; row >= 1; row--) {
        console.log(" ".repeat(n - row) + "* ".repeat(row));
    }
}

/* Uncomment to test:
rhombusOfStars(["4"]);
    */