function operationBetweenNumbers([arg1, arg2, arg3]) {
    let num1 = Number(arg1);
    let num2 = Number(arg2);
    let operation = arg3;

    let result;
    let evenOdd;

    // Check the operation
    if (operation == "+") {
        result = num1 + num2;
    }
    else if (operation == "-") {
        result = num1 - num2;
    }
    else if (operation == "*") {
        result = num1 * num2;
    }
    else if (operation == "/") {
        result = num1 / num2;
    }
    else if (operation == "%") {
        result = num1 % num2;
    }

    // Check Even or Odd
    if (result % 2 == 0) {
        evenOdd = "even";
    }

    else {
        evenOdd = "odd";
    }

    // Check dividing by 0
    if ((operation == "/" || operation == "%") && num2 == 0) {
        console.log(`Cannot divide ${num1} by zero`)
    }

    // Print the result
    if (operation == "+" || operation == "-" || operation == "*") {
        console.log(`${num1} ${operation} ${num2} = ${result} - ${evenOdd}`);
    }

    else if (operation == "/" && num2 != 0) {
        console.log(`${num1} ${operation} ${num2} = ${result.toFixed(2)}`);
    }

    else if (operation == "%" && num2 != 0) {
        console.log(`${num1} ${operation} ${num2} = ${result}`);
    }
}

/* Uncomment to test:
operationBetweenNumbers(["10", "12", "+"]);
operationBetweenNumbers(["10", "1", "-"]);
operationBetweenNumbers(["7", "3", "*"]);
operationBetweenNumbers(["123", "12", "/"]);
operationBetweenNumbers(["10", "3", "%"]);
operationBetweenNumbers(["112", "0", "/"]);
operationBetweenNumbers(["10", "0", "%"]);
    */