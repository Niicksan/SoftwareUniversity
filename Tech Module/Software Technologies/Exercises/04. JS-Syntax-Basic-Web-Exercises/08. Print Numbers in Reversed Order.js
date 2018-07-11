function reverse(nums) {
    let arr = [];

    for (let number of nums) {
        arr.push(number);
    }

    arr.reverse();

    for (let number of arr) {
        console.log(number);
    }
}

reverse(['10', '15', '20']);