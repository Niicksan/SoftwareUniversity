function priceForHotelRoom([arg1, arg2]) {
    let month = arg1;
    let nights = Number(arg2);

    let studio;
    let apartment;
    let discountStudio = 1;
    let discountApart = 1;

    if (month == "May" || month == "October") {
        studio = nights * 50;
        apartment = nights * 65;
        if (nights > 7 && nights <= 14) {
            discountStudio *= 0.95;
        }
        else if (nights > 14) {
            discountStudio *= 0.70; 
            discountApart *= 0.90;
        }
    }
    else if (month == "June" || month == "September") {
        studio = nights * 75.20;
        apartment = nights * 68.70;
        if (nights > 14) {
            discountStudio *= 0.80;
            discountApart *= 0.90;
        }
    }
    else if (month == "July" || month == "August") {
        studio = nights * 76;
        apartment = nights * 77;
        if (nights > 14) {
            discountApart *= 0.90;
        }
    }

    console.log(`Apartment: ${(apartment * discountApart).toFixed(2)} lv.`);
    console.log(`Studio: ${(studio * discountStudio).toFixed(2)} lv.`);
}

/* Uncomment to test:
priceForHotelRoom(["May", "15"]);
priceForHotelRoom(["June", "14"]);
priceForHotelRoom(["August", "20"]);
    */