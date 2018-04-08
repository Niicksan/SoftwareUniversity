function histogram(args) {
    let n = Number(args[0]);

    let p1 = 0;
    let p2 = 0;
    let p3 = 0;
    let p4 = 0;
    let p5 = 0;

    let countP1 = 0;
    let countP2 = 0;
    let countP3 = 0;
    let countP4 = 0;
    let countP5 = 0;

    for (var i = 1; i <= n; i++) {
        let number = Number(args[i]);

        if (number < 200) {
            countP1++;
        }
        else if (number >= 200 && number < 400) {
            countP2++;
        }
        else if (number >= 400 && number < 600) {
            countP3++;
        }
        else if (number >= 600 && number < 800) {
            countP4++;
        }
        else {
            countP5++;
        }
    }

    p1 = (countP1 * 100.00) / n;
    p2 = (countP2 * 100.00) / n;
    p3 = (countP3 * 100.00) / n;
    p4 = (countP4 * 100.00) / n;
    p5 = (countP5 * 100.00) / n;

    console.log(`${p1.toFixed(2)}%`);
    console.log(`${p2.toFixed(2)}%`);
    console.log(`${p3.toFixed(2)}%`);
    console.log(`${p4.toFixed(2)}%`);
    console.log(`${p5.toFixed(2)}%`);
}

/* Uncomment to test:
histogram(["3", "1", "2", "999"]);
histogram(["4", "53", "7", "56", "999"]);
histogram(["7", "800", "801", "250", "199", "399", "599", "799"]);
histogram(["9", "367", "99", "250", "200", "799", "999", "333", "555", "111", "9"]);
    */