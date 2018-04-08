function backToThePast([arg1, arg2]) {
    let inheritance = arg1;
    let year = Number(arg2);

    let ageBoy = 18;

    let moneyNeeded = 0;

    for (let years = 1800; years <= year; years++) {
        if (years % 2 == 0) {
            moneyNeeded += 12000;
            ageBoy++;
        }

        else {
            moneyNeeded += (12000 + (ageBoy * 50));
            ageBoy++;
        }
    }

    if (moneyNeeded <= inheritance) {
        console.log("Yes! He will live a carefree life and will have " + `${(inheritance - moneyNeeded).toFixed(2)}` + " dollars left.");
    }

    else {
        console.log("He will need " + `${(moneyNeeded - inheritance).toFixed(2)}` + " dollars to survive.");
    }
}

/* Uncomment to test:
backToThePast(["100000.15", "1808"]);
    */