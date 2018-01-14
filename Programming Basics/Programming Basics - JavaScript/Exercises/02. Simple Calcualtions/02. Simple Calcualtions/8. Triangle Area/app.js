function triangleArea([arg1, arg2]) {
    let a = Number(arg1);
    let h1 = Number(arg2);
    let area = (a * h1) / 2;

    console.log(`Triangle are = ${area.toFixed(2)}`);
}

/*Uncomment to test:
triangleArea(["20","30"]);
triangleArea(["15","35"]);
triangleArea(["7.75","8.45"]);
triangleArea(["1.23456","4.56789"]);
*/