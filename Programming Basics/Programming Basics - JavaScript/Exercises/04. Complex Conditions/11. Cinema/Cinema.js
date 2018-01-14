function calculateCinemaIncome([arg1, arg2, arg3]) {
    let type = arg1;
    let rows = Number(arg2);
    let cols = Number(arg3);

    let income;
    switch (type) {
        case "Premiere": {
            income = 12 * rows * cols;
            break;
        }
        case "Normal": {
            income = 7.50 * rows * cols;
            break;
        }
        case "Discount": {
            income = 5 * rows * cols;
        }
    }
    console.log(`${income.toFixed(2)} leva`);
}

/* Uncomment to test:
calculateCinemaIncome(["Normal", "21", "13"]);
    */