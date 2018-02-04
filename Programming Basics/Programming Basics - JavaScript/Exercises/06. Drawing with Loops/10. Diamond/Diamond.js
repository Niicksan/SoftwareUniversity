function drawDiamond([arg1]) {
    let n = Number(arg1);
    let stars = 1;
    let centralDashes = 1;
    let leftRight = parseInt((n - 1) / 2); 

    if (n % 2 === 0) {
        stars++;
        centralDashes++;
    }

    for (let row = 1; row <= parseInt((n + 1) / 2); row++) {
        if (row === 1) {
            console.log("-".repeat(leftRight) + "*".repeat(stars) + "-".repeat(leftRight));
            leftRight--;
        }

        else {
            console.log("-".repeat(leftRight) + "*" + "-".repeat(centralDashes) + "*" + "-".repeat(leftRight));
            leftRight--;
            centralDashes += 2;
        }
    }

    leftRight = 1;
    centralDashes -= 4;
    for (let row = 1; row <= parseInt((n - 1) / 2); row++) {
        
        if (row == parseInt((n - 1) / 2)) {
            console.log("-".repeat(leftRight) + "*".repeat(stars) + "-".repeat(leftRight));
        }
        else { 
            console.log("-".repeat(leftRight) + "*" + "-".repeat(centralDashes) + "*" + "-".repeat(leftRight));
            leftRight++;
            centralDashes -= 2;
        }
    }
}

/* Uncomment to test:
drawDiamond(["9"]);
    */