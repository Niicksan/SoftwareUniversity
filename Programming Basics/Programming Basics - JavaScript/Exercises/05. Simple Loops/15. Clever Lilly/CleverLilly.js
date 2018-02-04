function collectedMoneyByCleverLilly([arg1, arg2, arg3]) {
    let age = Number(arg1);
    let moneyNeeded = Number(arg2);
    let moneyPerToys = Number(arg3);
    let toys = Number(0);
    let gift = Number(0);
    let money = Number(0);

    for (let years = 1; years <= age; years++) {
        if (years % 2 == 1) {
            toys++;
        }
        else if (years % 2 == 0) {
            gift += 10;
            money += gift - 1;
        }
    }

    let moneyCollected = money + (toys * moneyPerToys);
    let diff = Math.abs(moneyNeeded - moneyCollected);
    if (moneyCollected >= moneyNeeded) {
        console.log(`Yes! ${diff.toFixed(2)}`);
    }
    else {
        console.log(`No! ${diff.toFixed(2)}`);
    }
}

/* Uncomment to test:
collectedMoneyByCleverLilly(["10", "170.00", "6"]);
collectedMoneyByCleverLilly(["21", "1570.98", "3"]);
    */