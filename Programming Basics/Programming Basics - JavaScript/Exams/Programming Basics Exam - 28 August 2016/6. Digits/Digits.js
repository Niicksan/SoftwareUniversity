function digit([arg1]) {
    let number = Number(arg1);

    let firstDig = parseInt(number / 100);
    let secondDig = parseInt((number / 10) % 10);
    let lastDig = number % 10;

    let rows = firstDig + secondDig;
    let cols = firstDig + lastDig;

    for (let row = 1; row <= rows; row++)
    {
       
        for (let col = 1; col <= cols; col++)
        {
            var digits = "";

            if (number % 5 == 0) {
                number -= firstDig;
            }

            else if (number % 3 == 0) {
                number -= secondDig;
            }

            else {
                number += lastDig;
            }
            digits += `${number} `;
            console.log.apply(console, number);
        }
    }
}

digit(["132"]);