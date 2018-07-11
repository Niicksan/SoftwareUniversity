function NegativeOrPositive(nums) {
    let count = 0;

    for (let i = 0; i < nums.length ; i++) {
        if (Number(nums[i]) < 0) {
            count++;
        }
    }

    if (count % 2 === 1) {
        console.log('Negative');
    }
    else {
        console.log('Positive')
    }
}

NegativeOrPositive(['2', '3', '-1']);