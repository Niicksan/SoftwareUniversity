'use strict';

function calculate(arr1, arr2, arr3) {
    var sumLength;
    var averageLength;

    var firstArgumentLength = arr1.length;  
    var secondArgumentLength = arr2.length;
    var thirdArgumentLength = arr3.length;

    sumLength = firstArgumentLength + secondArgumentLength + thirdArgumentLength;
    averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}

calculate('chocolate', 'ice cream', 'cake');
calculate('pasta', '5', '22.3');