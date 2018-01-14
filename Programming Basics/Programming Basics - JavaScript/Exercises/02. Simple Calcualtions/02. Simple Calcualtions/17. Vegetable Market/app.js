function calculateIncomesInEuro([arg1, arg2, arg3, arg4]) {
    let kgVegetablesPrice = parseFloat(arg1);
    let kgFruitsPrice = parseFloat(arg2);
    let kgVegetables = Number(arg3);
    let kgFruits = Number(arg4);

    let vegetablesIncomes = kgVegetablesPrice * kgVegetables;
    let fruitsIncomes = kgFruitsPrice * kgFruits;
    let totalIncomeInLeva = vegetablesIncomes + fruitsIncomes;
    let totalIncomeInEuro = totalIncomeInLeva / 1.94;
    console.log(totalIncomeInEuro.toFixed(2));
}

/* Uncomment to test:
calculateIncomesInEuro(["0.194", "19.4","10", "10"]);
calculateIncomesInEuro(["1.5", "2.5","10", "10"]);
    */