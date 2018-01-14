function calculateDailyEarnings([arg1, arg2, arg3]) {
    let workingDays = parseInt(arg1);
    let moneyPerDay = parseFloat(arg2);
    let dollar = parseFloat(arg3);

    let monthly = workingDays * moneyPerDay;
    let yearlyEarningsInDollars = monthly * 12 + monthly * 2.5;
    let taxes = yearlyEarningsInDollars * 0.25;
    yearlyEarningsInDollars -= taxes;

    let yearlyEarningsInLeva = yearlyEarningsInDollars * dollar;
    let dailyEarnings = yearlyEarningsInLeva / 365;
    console.log(dailyEarnings.toFixed(2));
}

/* Uncomment to test:
calculateDailyEarnings(["21", "75.00", "1.59"]);
calculateDailyEarnings(["15", "105", "1.71"]);
calculateDailyEarnings(["22", "199.99", "1.50"]);
    */