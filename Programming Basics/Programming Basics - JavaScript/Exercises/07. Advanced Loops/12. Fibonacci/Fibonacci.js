function fibonacci([arg1]) {
    let n = Number(arg1);
    let f0 = 1;
    let f1 = 1;

    for (let i = 1; i < n; i++) {
        let fNext = f0 + f1;
        f0 = f1;
        f1 = fNext;
    }
    console.log(f1);
}

/* Uncomment to test:
fibonacci(["0"]);
fibonacci(["10"]);
    */