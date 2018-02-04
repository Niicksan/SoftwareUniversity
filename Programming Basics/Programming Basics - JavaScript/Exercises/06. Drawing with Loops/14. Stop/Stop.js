function drawStop([arg1]) {
    let n = Number(arg1);

    let dots = n + 1;
    let dashes = 2 * n + 1;

    for (let row = 1; row <= 2 * n + 2; row++) {
        if (row == 1) {
            console.log(".".repeat(dots) + "_".repeat(dashes) + ".".repeat(dots));
            dots--;
            dashes -= 2;
        }
        else if (row > 1 && row <= n + 1) {
            console.log(".".repeat(dots) + "//" + "_".repeat(dashes) + "\\\\" + ".".repeat(dots));
            dots--;
            dashes += 2;
        }
        else if (row == n + 2) {
            let stop = (dashes - 5) / 2;
            console.log("//" + "_".repeat(stop) + "STOP!" + "_".repeat(stop) + "\\\\");
        }
        else if (row > n + 2) {
            console.log(".".repeat(dots) + "\\\\" + "_".repeat(dashes) + "//" + ".".repeat(dots));
            dots++;
            dashes -= 2;
        }
    }
}


drawStop(["5"]);