function checkTheNumber([arg1]) {
    let number = Number(arg1);

    if (number < 100) {
        console.log("Less than 100");
    }

    else if (number >= 100 && number <= 200) {
        console.log("Between 100 and 200");
    }

    else {
        console.log("Greater than 200");
    }
}

/* Uncomment to test:
checkTheNumber(["95"]);
checkTheNumber(["120"]);
checkTheNumber(["210"]);
    */