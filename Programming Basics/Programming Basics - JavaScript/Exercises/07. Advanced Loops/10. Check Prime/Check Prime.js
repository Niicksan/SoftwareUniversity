function chechPrime([arg1]) {
    let n = Number(arg1);
    let isPrime = true;

    if (n < 2) {
        isPrime = false;
    }

    for (let i = 2; i <= Math.sqrt(n); i++) {
        if (n % i == 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) {
        console.log("Prime");
    }
    else {
        console.log("Not Prime");
    }
}

/* Uncomment to test:
chechPrime(["-1"]);
chechPrime(["0"]);
chechPrime(["1"]);
chechPrime(["2"]);
chechPrime(["3"]);
chechPrime(["4"]);
chechPrime(["5"]);
chechPrime(["7"]);
    */