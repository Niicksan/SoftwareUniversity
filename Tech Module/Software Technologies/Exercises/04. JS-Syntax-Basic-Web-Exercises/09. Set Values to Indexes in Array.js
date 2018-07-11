function setValue(nums) {
    let n = (nums[0]);
    
    let arr = new Array(Number.parseInt(n));

    for (let i = 1; i < nums.length; i++) {
        let strings = [];
        strings.push(nums[i].split(" - "));

        let index = Number(strings[0][0]);
        let number = Number(strings[0][1]);

        arr[index] = number;
    }
    for (let number of arr) {
        if (number == undefined){
            number = 0;
        }
        console.log(number);
    }
}

setValue(['2', '0 - 5', '6 - 6', '0 - 7']);