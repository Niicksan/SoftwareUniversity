function sumDigits([arg1]) {
    let num = Number(arg1);
    let sum = 0;

    do {
        let dig = num % 10;
        sum += dig;
        num = Math.floor(num / 10);

    } while (num != 0);
    console.log(sum);
}

/* Uncomment to test:
sumDigits(["5634"]);
sumDigits(["19"]);
sumDigits(["5"]);
sumDigits(["17151"]);
    */
