'use strict';

function sum(n, m) {
    let num1 = Number(n); //let num1 = +n
    let num2 = Number(m); //let num1 = +m

    let result = 0;

    for(let i = num1; i <= num2; i++) {
        result +=i;
    }

    return result;
}

console.log(sum('1', '5'));