function printSquare([arg1]) {
    let n = Number(arg1);

    for (let i = 0; i < n; i++) {
        let row = "";
        if (i === 0 || i === (n - 1)) {
            row = "*".repeat(n);
        }
        else {
            row += '*';
            let intervals = " ".repeat(n - 2);
            row += intervals;
            row += '*';
        }
        console.log(row);
    }
}

/*Uncomment to test:
printSquare("3");
printSquare("4");
printSquare("5");*/
