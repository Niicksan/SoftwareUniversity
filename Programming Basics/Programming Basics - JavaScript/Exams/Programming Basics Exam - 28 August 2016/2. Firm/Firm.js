function firm([arg1, arg2, arg3]) {
    let hours = Number(arg1);
    let days = Number(arg2);
    let workers = Number(arg3);

    let availableDays = (days * 0.90);
    let workingHours = availableDays * 8;
    let overtimeHours = days * 2 * workers;
    let totalHoures = Math.floor(workingHours + overtimeHours);
    let difference = Math.abs(hours - totalHoures);

    if (totalHoures >= hours) {
        console.log("Yes!" + `${difference}` + " hours left.");
    }

    else {
        console.log("Not enough time!" + `${difference}` + " hours needed.");

    }
}

/* Uncomment to test:
firm(["99", "3", "1"])
    */