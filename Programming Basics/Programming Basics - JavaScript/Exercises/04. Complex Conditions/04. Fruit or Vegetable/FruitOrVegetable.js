function checkFruitOrVegetable([arg1]) {
    let product = arg1;

    switch (product) {
        case "banana": {
            console.log("fruit");
            break;
        }
        case "apple": {
            console.log("fruit");
            break;
        }
        case "kiwi": {
            console.log("fruit");
            break;
        }
        case "cherry": {
            console.log("fruit");
            break;
        }
        case "lemon": {
            console.log("fruit");
            break;
        }
        case "grapes": {
            console.log("fruit");
            break;
        }
        case "tomato": {
            console.log("vegetable");
            break;
        }
        case "cucumber": {
            console.log("vegetable");
            break;
        }
        case "pepper": {
            console.log("vegetable");
            break;
        }
        case "carrot": {
            console.log("vegetable");
            break;
        }
        default: console.log("unknown");
            break;
    }
}

/* Uncomment to test:
checkFruitOrVegetable(["banana"]);
checkFruitOrVegetable(["apple"]);
checkFruitOrVegetable(["tomato"]);
checkFruitOrVegetable(["water"]);
    */


function fruitOrVegetable([arg1]) {
    let product = arg1;
    if (product == "banana" || product == "apple" || product == "kiwi" ||
        product == "cherry" || product == "lemon" || product == "grapes") {
        console.log("fruit");
    }

    else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot") {
        console.log("vegetable");
    }

    else {
        console.log("unknown");
    }
}

fruitOrVegetable(["banana"]);
fruitOrVegetable(["apple"]);
fruitOrVegetable(["tomato"]);
fruitOrVegetable(["water"]);