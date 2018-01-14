function trainingLabWorkplaces([arg1, arg2]) {
    let lengthInMeters = parseFloat(arg1);
    let widthInMeters = parseFloat(arg2);

    let length = lengthInMeters * 100;
    let width = widthInMeters * 100;
    width -= 100;

    let rows = Math.floor(length / 120);
    let deskPerRow = Math.floor(width / 70);

    let workplaces = (rows * deskPerRow);
    workplaces -= 3;
    console.log(workplaces);
}

/* Uncomment to test:
trainingLabWorkplaces(["15", "8.9"])
trainingLabWorkplaces(["8.4", "5.2"])
*/

