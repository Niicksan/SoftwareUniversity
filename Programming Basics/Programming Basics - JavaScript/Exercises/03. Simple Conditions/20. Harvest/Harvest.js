function calculateTheWine([arg1, arg2, arg3, arg4]) {
    let area = parseFloat(arg1);
    let grapes = parseFloat(arg2);
    let litersNeeded = Number(arg3);
    let workers = Number(arg4);

    let harvestForWine = area * 0.40;
    let khGrapes = grapes * harvestForWine;
    let litersWine = khGrapes / 2.5;

    if (litersWine < litersNeeded) {
        console.log(`It will be a tough winter! More ${Math.floor(litersNeeded - litersWine)} liters wine needed.`);
    }

    else {
        console.log(`Good harvest this year! Total wine: ${Math.floor(litersWine)} liters.`);
        let litersWineLeft = Math.ceil(litersWine - litersNeeded);
        let litersWinePerWorker = Math.ceil(litersWineLeft / workers);
        console.log(`${litersWineLeft} liters left -> ${litersWinePerWorker} liters per person.`);
    }
}

/* Uncomment to test:
calculateTheWine(["650", "2", "175", "3"]);
calculateTheWine(["1020", "1.5", "425", "4"]);
    */