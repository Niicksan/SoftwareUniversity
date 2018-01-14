function calculateMoney([arg1, arg2, arg3]) {
    let bitcoins = parseInt(arg1);
    let yuans = parseFloat(arg2);
    let comission = parseFloat(arg3);

    let bitcoinsInEuro = bitcoins * 1168 / 1.95;
    let yuansInEuro = (yuans * 0.15 * 1.76) / 1.95;

    let totalEuro = bitcoinsInEuro + yuansInEuro;
    totalEuro = totalEuro * (100 - comission) / 100;
    console.log(totalEuro.toFixed(2));
}

/* Uncomment to test:
calculateMoney(["1", "5", "5"]);
calculateMoney(["20", "5678", "2.4"]);
calculateMoney(["7", "50200.12", "3"]);
   */