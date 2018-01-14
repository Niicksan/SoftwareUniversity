function numberTo10ToText([arg1]) {
    let number = Number(arg1);

    if (number == "1") {
        console.log("one");
    }

    else if (number == "2") {
        console.log("two");
    } 

    else if (number == "3") {
        console.log("three");
    }   

    else if (number == "4") {
        console.log("four");
    }  

    else if (number == "5") {
        console.log("five");
    }

    else if (number == "6") {
        console.log("six");
    } 

    else if (number == "7") {
        console.log("seven");
    }  

    else if (number == "8") {
        console.log("eight");
    }  

    else if (number == "9") {
        console.log("nine");
    }  

    else {
        console.log("number too big");
    }


    /*
    switch(number){
        case 0: {
            console.log("zero");
            break;
        }
        case 1: {
            console.log("one");
            break;
        }
        case 2: {
            console.log("two");
            break;
        }
        case 3: {
            console.log("three");
            break;
        }
        case 4: {
            console.log("four");
            break;
        }
        case 5: {
            console.log("five");
            break;
        }
        case 6: {
            console.log("six");
            break;
        }
        case 7: {
            console.log("seven")
            break;
        }
        case 8: {
            console.log("eight");
            break;
        }
        case 9: {
            console.log("nine");
            break;
        }
        default:{
            console.log("number too big");
            break;
        }
    }
    */
}

/* Uncomment to test:
numberTo10ToText(["5"]);
numberTo10ToText(["1"]);
numberTo10ToText(["9"]);
numberTo10ToText(["10"]);
    */