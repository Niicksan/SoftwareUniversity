function triangleDollars([arg1]) {
    let n = Number(arg1);

    for (let row = 1; row <= n; row++) {
        console.log("$ ".repeat(row));
    }
}

/* Uncomment to test:
triangleDollars(["4"]);
    */


function triangleOfDollars([arg1]) {
    let n = Number(arg1);
    let dollars = "";

    for (let row = 1; row <= n; row++) {
        for (var col = 1; col <= row; col++) {
            dollars += "$ ";
        }
        console.log(dollars);
        dollars = "";
    }
}

/* Uncomment to test:
triangleOfDollars(["4"]);
    */
  