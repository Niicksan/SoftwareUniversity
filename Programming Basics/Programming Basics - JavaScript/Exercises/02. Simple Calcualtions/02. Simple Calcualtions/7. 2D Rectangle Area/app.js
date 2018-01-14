function rectangleAreaParameter([arg1, arg2, arg3, arg4]) {
    let x1 = Number(arg1);
    let y1 = Number(arg2);
    let x2 = Number(arg3);
    let y2 = Number(arg4);

    let width = Math.max(x1, x2) - Math.min(x1, x2);
    let height = Math.max(y1, y2) - Math.min(y1, y2);

    console.log(`Area = ${width * height}`);
    console.log(`Perimeter = ${2 * (width + height)}`);
}

/*Uncomment to test:
rectangleAreaParameter(["60", "20", "10", "50"]);*/
