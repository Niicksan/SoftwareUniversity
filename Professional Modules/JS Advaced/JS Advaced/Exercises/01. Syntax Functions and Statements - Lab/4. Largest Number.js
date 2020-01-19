'use strict';

function largestNumber(num1, num2, num3) {
    // let num1 = +number1; //Number(number1)
    // let num2 = +number2; //Number(number2)
    // let num3 = +number3; //Number(number3)
    
    let result;

    if (num1 > num2 && num1 > num3) {
        result = num1;
    }

    else if(num2 > num1 && num2 > num3) {
        result = num2;
    }

    else if(num3 > num1 && num3 > num2) {
        result = num3;
    }

    console.log(`The largest number is ${result}.`)
}

largestNumber(5, -3, 16);
