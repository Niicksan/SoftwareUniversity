function matchTickets([arg1, arg2, arg3]) {
    let budget = Number(arg1);
    let category = arg2;
    let people = Number(arg3);

    let budgetForTransport;
    let budgetForTickets;
    let budgetLeft;

    if (people <= 4) {
        budgetForTransport = budget * 0.75;
    }
    else if (people >= 5 && people < 10) {
        budgetForTransport = budget * 0.60;
    }
    else if (people >= 10 && people < 25) {
        budgetForTransport = budget * 0.50;
    }
    else if (people >= 25 && people < 50) {
        budgetForTransport = budget * 0.40;
    }
    else {
        budgetForTransport = budget * 0.25;
    }

    budgetLeft = budget - budgetForTransport;

    if (category == "VIP") {
        budgetForTickets = people * 499.99;
        let moneyLeft = Math.abs(budgetLeft - budgetForTickets);

        if (budgetLeft >= budgetForTickets) {
            console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`);
        }
        else {
            console.log(`Not enough money! You need ${moneyLeft.toFixed(2)} leva.`);
        }
    }

    else if (category == "Normal") {
        budgetForTickets = people * 249.99;
        let moneyLeft = Math.abs(budgetLeft - budgetForTickets);

        if (budgetLeft >= budgetForTickets) {
            console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`);
        }
        else {
            console.log(`Not enough money! You need ${moneyLeft.toFixed(2)} leva.`);
        }
    }
}

/* Uncomment to test:
matchTickets(["1000", "Normal", "1"]);
matchTickets(["30000", "VIP", "49"]);
    */
