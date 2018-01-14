function checkTheNumber([arg1]) {
    let number = Number(arg1);

    if (number != 0 && number < 100 || number > 200) {
        console.log("invalid");
    }

}

/*
checkTheNumber(["75"]);
checkTheNumber(["-1"]);
checkTheNumber(["150"]);
checkTheNumber(["100"]);
checkTheNumber(["220"]);
checkTheNumber(["200"]);
checkTheNumber(["199"]);
checkTheNumber(["0"]);
    */

function checktheNumber([arg1]) {
    let number = Number(arg1);

    let inrange = number == 0 || (number >= 100 && number <= 200);
    if (!inrange) {
        console.log("invalid");
    }
}

/* Uncomment to test:
checktheNumber(["75"]);
checktheNumber(["-1"]);
checktheNumber(["150"]);
checktheNumber(["100"]);
checktheNumber(["220"]);
checktheNumber(["200"]);
checktheNumber(["199"]);
checktheNumber(["0"]);
    */