function calculateTheTransportPrice([arg1, arg2]) {
    let km = Number(arg1);
    let periodOfTheDay = arg2;

    let price;
    if (km < 20) {
        if (periodOfTheDay == "day") {
            price = 0.70 + (0.79 * km);
        }

        else {
            price = 0.70 + (0.90 * km);
        }
    }

    else if (km >= 20 && km < 100) {
        price = 0.09 * km;
    }

    else {
        price = 0.06 * km;
    }

    console.log(price.toFixed(2));
}

/* Uncomment to test:
calculateTheTransportPrice(["5", "day"]);
calculateTheTransportPrice(["7", "night"]);
calculateTheTransportPrice(["25", "day"]);
calculateTheTransportPrice(["180", "night"]);
    */