function fruitShop([arg1, arg2, arg3]) {
    let fruit = arg1.toLowerCase();
    let day = arg2.toLowerCase();
    let quantity = Number(arg3);

    let price;
    if (day == "monday" || day == "tuesday" || day == "wednesday"
                        || day == "thursday" || day == "friday") {
        if (fruit == "banana") {
            price = 2.50 * quantity;
        }
        else if (fruit == "apple") {
            price = 1.20 * quantity;
        }
        else if (fruit == "orange") {
            price = 0.85 * quantity;
        }
        else if (fruit == "grapefruit") {
            price = 1.45 * quantity;
        }
        else if (fruit == "kiwi") {
            price = 2.70 * quantity;
        }
        else if (fruit == "pineapple") {
            price = 5.50 * quantity;
        }
        else if (fruit == "grapes") {
            price = 3.85 * quantity;
        }
        else {
            console.log("error")
        }
    }

    else if (day == "saturday" || day == "sunday") {
        if (fruit == "banana") {
            price = 2.70 * quantity;
        }
        else if (fruit == "apple") {
            price = 1.25 * quantity;
        }
        else if (fruit == "orange") {
            price = 0.90 * quantity;
        }
        else if (fruit == "grapefruit") {
            price = 1.60 * quantity;
        }
        else if (fruit == "kiwi") {
            price = 3.00 * quantity;
        }
        else if (fruit == "pineapple") {
            price = 5.60 * quantity;
        }
        else if (fruit == "grapes") {
            price = 4.20 * quantity;
        }
        else {
            console.log("error")
        }
    }
    else {
        console.log("error")
    }

    console.log(price);
}

/* Uncomment to test:
fruitShop(["apple", "tuesday", "2"]);
fruitShop(["orange", "sunday", "3"]);
fruitShop(["kiwi", "monday", "2.5"]);
    */