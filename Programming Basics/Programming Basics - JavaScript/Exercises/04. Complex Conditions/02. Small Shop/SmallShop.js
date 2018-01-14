function smallShop([arg1, arg2, arg3]) {
    let town = arg2.toLowerCase();
    let product = arg1.toLowerCase();
    let amount = parseFloat(arg3);

    let price;

    if (town == "sofia") {
        if (product == "coffee") {
            price = 0.50 * amount;
        }

        else if (product == "water") {
            price = 0.80 * amount;
        }

        else if (product == "beer") {
            price = 1.20 * amount;
        }

        else if (product == "sweets") {
            price = (1.45 * amount);
        }

        else if (product == "peanuts") {
            price = 1.60 * amount;
        }
    }

    else if (town == "plovdiv") {
        if (product == "coffee") {
            price = 0.40 * amount;
        }
    
        else if (product === "water") {
            price = 0.70 * amount;
        }

        else if (product == "beer") {
            price = 1.15 * amount;
        }

        else if (product == "sweets") {
            price = 1.30 * amount;
        }

        else if (product == "peanuts") {
            price = 1.50 * amount;
        }
    }

    else if (town == "varna") {
        if (product == "coffee") {
            price = 0.45 * amount;
        }

        else if (product == "water") {
            price = Number(0.70 * amount);
        }

        else if (product == "beer") {
            price = Number(1.10 * amount);
        }

        else if (product == "sweets") {
            price = Number(1.35 * amount);
        }

        else if (product == "peanuts") {
            price = Number(1.55 * amount);
        }
    }

    console.log(price);
}
/* Uncomment to test:
smallShop(["coffee", "varna", "2"]);
smallShop(["peanuts", "Plovdiv", "1"]);
smallShop(["beer", "Sofia", "6"]);
smallShop(["water", "Plovdiv", "3"]);
smallShop(["sweets", "sofia", "2.23"]);
    */
