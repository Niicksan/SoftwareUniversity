function oddEvenPosition(args) {
    let n = Number(args[0]);
    let evenSum = 0;
    let oddSum = 0;
    let oddMin = Number.POSITIVE_INFINITY; //   1000000000.0
    let oddMax = Number.NEGATIVE_INFINITY; // - 1000000000.0
    let evenMin = Number.POSITIVE_INFINITY;//   1000000000.0
    let evenMax = Number.NEGATIVE_INFINITY;// - 1000000000.0

    for (let i = 1; i <= n; i++) {
        let num = Number(args[i]);

        if (i % 2 == 0) {
            evenSum += num;

            if (evenMax < num) {
                evenMax = num;
            }

            if (evenMin > num) {
                evenMin = num;
            }
        }
        else {
            oddSum += num;

            if (oddMax < num) {
                oddMax = num;
            }

            if (oddMin > num) {
                oddMin = num;
            }
        }
    }

    // for ODD numbers
    console.log(`Oddsum=${oddSum},`);
    //---------------------------------------------------------------------------------------------------------------------
    if (oddMin == Number.POSITIVE_INFINITY) {
        console.log("OddMin=No,");
    }
    else {
        console.log(`OddMin=${oddMin},`);
    }
    //---------------------------------------------------------------------------------------------------------------------
    if (oddMax == Number.NEGATIVE_INFINITY) {
        console.log("OddMax=No,");
    }
    else {
        console.log(`OddMax=${oddMax},`);
    }
    //---------------------------------------------------------------------------------------------------------------------
    // for EVEN numbers
    console.log(`EvenSum=${evenSum},`);
    //---------------------------------------------------------------------------------------------------------------------
    if (evenMin == Number.POSITIVE_INFINITY) {
        console.log("EvenMin=No,");
    }
    else {
        console.log(`EvenMin=${evenMin},`);
    }
    //---------------------------------------------------------------------------------------------------------------------
    if (evenMax == Number.NEGATIVE_INFINITY) {
        console.log("EvenMax=No,");
    }
    else {
        console.log(`EvenMax=${evenMax},`);
    }
}

/* Uncomment to test:
oddEvenPosition(["6", "2", "3", "5", "4", "2", "1"]);
oddEvenPosition(["2", "1.5", "2.5"]);
oddEvenPosition(["1", "1"]);
oddEvenPosition(["0"]);
    */