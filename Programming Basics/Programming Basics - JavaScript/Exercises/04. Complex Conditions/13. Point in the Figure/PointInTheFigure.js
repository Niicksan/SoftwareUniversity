function checkPointInFigure([arg1, arg2, arg3]) {
    let h = parseInt(arg1);
    let x = parseInt(arg2);
    let y = parseInt(arg3);

    if ((x > h && x < 2 * h) && y == h) {
        console.log("inside");

    }
    else {
        if ((((x == 0 || x == 3 * h) && (y >= 0 && y <= h)) || ((y == 0 || y == h) && (x >= 0 && x <= 3 * h))) ||
            (((x == 2 * h || x == h) && (y >= h && y <= 4 * h)) || ((y == 4 * h) && (x >= h && x <= 2 * h)))) {
            console.log("border");
        }

        else if (((x > 0 && x < 3 * h) && (y > 0 && y < h)) ||
            ((x > h && x < 2 * h) && (y > h && y < 4 * h))) {
            console.log("inside");
        }

        else {
            console.log("outside");
        }
    }
}

/* Uncomment to test:
checkPointInFigure(["2", "3", "10"]);
checkPointInFigure(["2", "3", "1"]);
checkPointInFigure(["2", "2", "2"]);
checkPointInFigure(["2", "6", "0"]);
    */
   