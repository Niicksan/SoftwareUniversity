function powerOfTwo([arg1]) {
    let n = Number(arg1);
    let num = 1;
    
    for (let i = 0; i <= n; i++) {
        console.log(num);
        num *= 2;  
    }
}

/* Uncomment to test:
powerOfTwo(["5"]);
    */