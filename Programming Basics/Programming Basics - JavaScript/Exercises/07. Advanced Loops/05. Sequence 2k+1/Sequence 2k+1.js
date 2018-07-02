function sequence2KPlus1([arg1]) {
    let n = Number(arg1);
    let num = 1;

    while (num <= n) {
        console.log(num);
        num = num * 2 + 1;
    }
}

/* Uncomment to test:
sequence2KPlus1(["8"]);
    */