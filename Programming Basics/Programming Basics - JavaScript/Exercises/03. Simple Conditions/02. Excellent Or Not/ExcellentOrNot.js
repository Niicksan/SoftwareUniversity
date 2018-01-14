function excellentOrNot([arg1]) {
    let grade = parseFloat(arg1);

    if (grade >= 5.50) {
        console.log("Excellent!");
    }

    else {
        console.log("Not excellent.");
    }
}

/* Uncomment to test:
excellentOrNot(["6"]);
excellentOrNot(["5"]);
excellentOrNot(["5.50"]);
excellentOrNot(["5.49"]);
    */