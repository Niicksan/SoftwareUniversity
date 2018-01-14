function calculateAreaOfFigures(args){
    let figureType = args[0];
    let area = 0.0;

    if (figureType == "square") {
        let side = parseFloat(args[1]);
        area = side * side;
    }
    
    else if (figureType == "circle") {
        let radius = parseFloat(args[1]);
        area = Math.PI * radius * radius;
    }

    else if (figureType == "rectangle") {
        let width = parseFloat(args[1]);
        let lenght = parseFloat([args[2]]);
        area = width * lenght;
    }

    else if (figureType == "triangle") {
        let side = parseFloat(args[1]);
        let height = parseFloat([args[2]]);
        area = side * height / 2;
    }

    console.log(area.toFixed(3));
}

/* Uncomment to test:
calculateAreaOfFigures(["square", "5"]);
calculateAreaOfFigures(["rectangle", "7", "2.5"]);
calculateAreaOfFigures(["circle", "6"]);
calculateAreaOfFigures(["triangle", "4.5", "20"]);
    */
    
