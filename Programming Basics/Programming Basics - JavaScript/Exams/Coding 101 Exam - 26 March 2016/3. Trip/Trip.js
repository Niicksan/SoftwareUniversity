function moneyForTrip([arg1, arg2]) {
    let budget = Number(arg1);
    let season = arg2;

    let price;
    let location;
    let camapHotel;
    if (budget <= 100) {
        if (season == "summer") {
            price = budget * 0.30;
            location = "Bulgaria";
            camapHotel = "Camp";
        }
        else {
            price = budget * 0.70;
            location = "Bulgaria";
            camapHotel = "Hotel";
        }
    }

    else if (budget > 100 && budget <= 1000) {
        if (season == "summer") {
            price = budget * 0.40;
            location = "Balkans";
            camapHotel = "Camp";
        }
        else {
            price = budget * 0.80;
            location = "Balkans";
            camapHotel = "Hotel";
        }
    }

    else {
        price = budget * 0.90;
        location = "Europe";
        camapHotel = "Hotel";
    }

    console.log(`Somewhere in ${location}`);
    console.log(`${camapHotel} - ${price.toFixed(2)}`);
}

/* Uncomment to test:
moneyForTrip(["50", "summer"]);
moneyForTrip(["75", "winter"]);
moneyForTrip(["312", "summer"]);
moneyForTrip(["678.53", "winter"]);
moneyForTrip(["1500", "summer"]);
    */