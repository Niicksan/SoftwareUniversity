function christmasTree([arg1]) {
    let n = Number(arg1);

    console.log(" ".repeat(n + 1) + "|" + " ".repeat(n + 1));
    for (let row = 1; row <= n; row++) {
        console.log(" ".repeat(n - row) + "*".repeat(row) + " | " + "*".repeat(row) + " ".repeat(n));
    }
}

/* Uncomment to test:
christmasTree(["6"]);
    */


function treeOfChristmas([arg1]) {
    let n = Number(arg1);
    let intervals = n;
    let stars = 0;

    for (let row = 0; row <= n; row++) {
        console.log(" ".repeat(intervals) + "*".repeat(stars) + " | " + "*".repeat(stars) + " ".repeat(intervals));
        intervals--;
        stars++;
    }
}

/* Uncomment to test:
treeOfChristmas(["4"]);
    */
    