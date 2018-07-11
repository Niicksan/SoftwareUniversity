function operations(nums) {
    let x = Number(nums[0]);
    let y = Number(nums[1]);

    let result = 0;
    if (y >= x){
       result = x * y;
    }
    else {
        result = x / y;
    }

    console.log(result)
}

operations(['3', '2']);