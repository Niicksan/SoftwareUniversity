function sleepyTomCat([arg1]) {
    let holidays = Number(arg1);

    let totalMinutes = (365 - holidays) * 63 + (holidays * 127);
    let minDff = Math.abs(30000 - totalMinutes);

    let hours = parseInt(minDff / 60);
    let minutes = minDff % 60;

    if (totalMinutes <= 30000) {
        console.log(`Tom sleeps well`);
        console.log(`${hours} hours and ${minutes} minutes less for play`);
    }

    else {
        console.log(`Tom will run away`);
        console.log(`${hours} hours and ${minutes} minutes more for play`);
    }
}

/* Uncomment to test:
sleepyTomCat(["20"]);
sleepyTomCat(["113"]);
    */