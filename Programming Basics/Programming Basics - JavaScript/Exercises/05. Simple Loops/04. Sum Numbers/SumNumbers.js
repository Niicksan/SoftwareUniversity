function sumTheNumbers(args) {
    let n = Number(args[0]);
    let sum = 0;

    for (let i = 1; i <= n; i++) {
        sum += Number(args[i]); 
    }
    console.log(sum);
}

/* Uncomment to test:
sumTheNumbers(["2", "10", "20"]);
sumTheNumbers(["3", "-10", "-20", "-30"]);
sumTheNumbers(["3", "-10", "-20", "-30"]);
sumTheNumbers(["1", "999"]);
sumTheNumbers(["0"]);
    */