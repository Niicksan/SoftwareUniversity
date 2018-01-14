function evenOrOdd([arg1]) {
    let number = Number(arg1);

    if (number % 2 == 0) {
        console.log("even");
    }

    else {
        console.log("odd");
    }
}

/* Uncomment to test:
evenOrOdd(["2"]);
evenOrOdd(["3"]);
evenOrOdd(["25"]);
evenOrOdd(["1024"]);
    */