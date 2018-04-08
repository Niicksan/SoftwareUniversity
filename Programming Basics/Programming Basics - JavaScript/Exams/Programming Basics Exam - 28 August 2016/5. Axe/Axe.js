function drawAxe([args1]) {
    let n = Number(args1);

    let firstDashes = 3 * n;
    let centralDashes = 0;
    let lastDashes = (5 * n) - ((firstDashes + centralDashes) + 2);

    for (let i = 1; i <= n; i++)
    {
        console.log("-".repeat(firstDashes) + "*" + "-".repeat(centralDashes) + "*" + "-".repeat(lastDashes));
        centralDashes++;
        lastDashes--;
    }

    let dashes = n - 1;
    let LastDashes = (5 * n) - ((firstDashes + dashes) + 2);

    for (let row2 = 1; row2 <= n / 2; row2++)
    {
        console.log("*".repeat(firstDashes) + "*" + "-".repeat(dashes) + "*" + "-".repeat(LastDashes));
    }

    for (let row3 = 1; row3 < Math.floor(n / 2); row3++)
    {
        console.log("-".repeat(firstDashes) + "*" + "-".repeat(dashes) + "*" + "-".repeat(LastDashes));
        firstDashes--;
        dashes += 2;
        LastDashes--;
    }

    console.log("-".repeat(firstDashes) + "*" + "*".repeat(dashes) + "*" + "-".repeat(LastDashes));
}

/* Uncomment to test:
drawAxe(["2"]);
    */