function hospital(args) {
    let days = Number(args[0]);
    let doctors = 7;
    let treated = 0;
    let untreated = 0;

    for (let rowPatiesnts = 1; rowPatiesnts <= days; rowPatiesnts++)
    {
        let patients = Number(args[1]);

        if (rowPatiesnts % 3 == 0) {
            if (untreated > treated) {
                doctors++;
            }
        }

        if (patients <= doctors) {
            treated = treated + patients;
        }

        else {
            treated = treated + doctors;
            untreated = untreated + (patients - doctors);
        }
    }
    console.log(`Treated patients: ${treated}.`);
    console.log(`Untreated patients: ${untreated}.`);
}

/* Uncomment to test:
hospital(["3", "7", "7", "7"]);
    */