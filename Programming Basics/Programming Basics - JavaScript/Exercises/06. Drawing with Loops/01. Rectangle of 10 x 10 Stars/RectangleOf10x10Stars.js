function rectangleStars() {

    for (let row = 1; row <= 10; row++) {
        console.log("*".repeat(10));
    }
}

/* Uncomment to test:
rectangleStars()
    */

function rectangleOfStars() {
    let result = "";

    for (let row = 1; row <= 10; row++) {
        for (let col = 1; col <= 10; col++) {
            result += "*";
        }
        console.log(result);
        result = "";
    }
}

/* Uncomment to test:
rectangleOfStars();
    */
    