function circleAreaPerimeter([arg1]) {
    let r = parseFloat(arg1);
    let area = Math.PI * r * r;
    let perimeter = 2 * Math.PI * r;

    console.log(area);
    console.log(perimeter);
}

/*Uncomment to test:
circleAreaPerimeter("3");*/