function largest3Numbers(arr) {
    let nums = arr.map(Number);
    let numsSorted = nums.sort((a, b) => b - a);
    let numbers = Math.min(3, arr.length);

    for (let i = 0; i < numbers; i++) {
        console.log(numsSorted[i]);
    }
}

largest3Numbers(['10', '30', '15', '20', '50', '5']);
