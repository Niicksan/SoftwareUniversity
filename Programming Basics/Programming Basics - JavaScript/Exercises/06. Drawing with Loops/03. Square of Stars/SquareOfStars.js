function squareOfStars([arg1]) {
    let n = Number(arg1);

    for (var row = 1; row <= n; row++) {
        console.log("* ".repeat(n))
    }
}

/* Uncomment to test:
squareOfStars(["4"]);
    */

function squareStars([arg1]) {
    let n = Number(arg1);
    let square = "";

    for (var row = 1; row <= n; row++) {
        for (var col = 1; col <= n; col++) {
            square += "* ";
        }
        console.log(square);
        square = "";
    }
}

/* Uncomment to test:
squareStars(["4"]);
    */