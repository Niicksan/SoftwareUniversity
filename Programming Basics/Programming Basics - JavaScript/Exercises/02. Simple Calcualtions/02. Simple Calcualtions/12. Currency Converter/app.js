function currencyConverter([arg1, arg2, arg3]) {
    let value = parseFloat(arg1);
    let firstCurrency = arg2;
    let secondCurrency = arg3;

    let currency;
    let currencyStr;
    if (arg2 == "USD") {
        if (arg3 == "BGN") {
            currency = value * 1.79549;
            currencyStr = "BGN";
        }

        else if (arg3 == "EUR") {
            currency = value * 0.91801;
            currencyStr = "EUR";
        }

        else if (arg3 == "GBP") {
            currency = value * 0.70854;
            currencyStr = "GBP";
        }
    }

    else if (arg2 == "BGN") {
        if (arg3 == "USD") {
            currency = value / 1.79549;
            currencyStr = "USD";
        }

        else if (arg3 == "EUR") {
            currency = value / 1.95583;
            currencyStr = "EUR";
        }

        else if (arg3 == "GBP") {
            currency = value / 2.53405;
            currencyStr = "GBP";
        }
    }

    else if (arg2 == "EUR") {
        if (arg3 == "BGN") {
            currency = value * 2.53405;
            currencyStr = "BGN";
        }

        else if (arg3 == "USD") {
            currency = value * 1.08930;
            currencyStr = "USD";
        }

        else if (arg3 == "GBP") {
            currency = value * 1.95583 / 2.53405;
            currencyStr = "GBP";
        }
    }

    else {
        if (arg3 == "BGN") {
            currency = value * 0.39462;
            currencyStr = "BGN";
        }

        else if (arg3 == "USD") {
            currency = value * 2.53405 / 1.79549;
            currencyStr = "USD";
        }

        else if (arg3 == "EUR") {
            currency = value * 0.77181;
            currencyStr = "EUR";
        }
    }

    console.log(currency.toFixed(2) + " " + currencyStr);
}

/*Uncomment to test:
currencyConverter(["20", "USD", "BGN"]);
currencyConverter(["100", "BGN", "EUR"]);
currencyConverter(["12.35", "EUR", "GBP"]);
currencyConverter(["150.35", "USD", "EUR"]);
*/