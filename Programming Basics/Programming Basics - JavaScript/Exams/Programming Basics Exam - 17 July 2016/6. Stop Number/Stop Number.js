function stopNumber([arg1, arg2, arg3]) {
    let n = Number(arg1);
    let m = Number(arg2);
    let s = Number(arg3);

    var stopNumber = "";

    for (let i = m; i >= n; i--)
    {
        if (i % 2 == 0 && i % 3 == 0) {
            if (i == s) {
                break;
            }

            else {
                stopNumber += i + " ";
            }
        }
    }

    console.log(stopNumber);
}

/* Uncomment to test:
stopNumber(["1", "36", "12"]);
    */