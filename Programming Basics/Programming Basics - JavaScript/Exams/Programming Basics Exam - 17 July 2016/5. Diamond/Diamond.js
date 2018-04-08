function drowDiamond([arg1]) {
    let n = Number(arg1);

    let dots = n;
    let stars = (5 * n) - ((2 * n) + 2);

    for (let first = 1; first <= n ; first++)
    {
        if (first == 1) {
            console.log(".".repeat(dots) + "*" + "*".repeat(stars) + "*" + ".".repeat(dots));
            dots--;
            stars += 2;
        }

        else {
            console.log(".".repeat(dots) + "*" + ".".repeat(stars) + "*" + ".".repeat(dots));
            dots--;
            stars += 2;
        }
    }

    console.log("*".repeat(5 * n));

    let firstDots = 1;
    let centralDots = (5 * n) - 4;

    for (let second = 1; second <= 2 * n + 1; second++)
    {
        if (second < 2 * n + 1) {
            console.log(".".repeat(firstDots) + "*" + ".".repeat(centralDots) + "*" + ".".repeat(firstDots));
            firstDots++;
            centralDots -= 2;
        }

        else {
            console.log(".".repeat(firstDots) + "*" + "*".repeat(centralDots) + "*" + ".".repeat(firstDots));
        }
    }
}

/* Uncomment to test:
drowDiamond(["6"]);
    */