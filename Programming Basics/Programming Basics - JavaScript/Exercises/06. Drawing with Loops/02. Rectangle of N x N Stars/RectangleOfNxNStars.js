function rectangleStars([arg1]) {
    let n = Number(arg1);

    for (let row = 1; row <= n; row++) {
        console.log("* ".repeat(n));
    }
}

/* Uncomment to test:
rectangleStars(["3"]);
    */


function rectangleOfStars([arg1]) {
    let n = Number(arg1);
    let result = ""

    for (let row = 1; row <= n; row++) {
        for (let col = 1; col <= n; col++) {
            result += "*";
        }
        console.log(result);
        result = "";
    }
}

/* Uncomment to test:
rectangleOfStars(["3"]);
    */
    
