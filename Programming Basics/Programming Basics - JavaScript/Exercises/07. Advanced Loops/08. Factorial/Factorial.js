function factorial([arg1]) {
    let num = Number(arg1);
    let fact = 1;
    let i = 1

    while (i <= num) {
        fact *= i;
        i++;
    }
    console.log(fact);
}

/* Uncomment to test:
factorial(["1"]);
factorial(["2"]);
factorial(["5"]);
factorial(["6"]);
factorial(["10"]);
    */

function factorial([arg1]) {
    let num = Number(arg1);
    let fact = 1;

    do {
        fact *= num;
        num--;
    } while (num > 1);
    console.log(fact);
}

/* Uncomment to test:
factorial(["1"]);
factorial(["2"]);
factorial(["5"]);
factorial(["6"]);
factorial(["10"]);
    */