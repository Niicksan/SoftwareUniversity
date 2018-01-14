function sumSeconds([arg1, arg2, arg3]) {
    // Ver 1.0
    let first = Number(arg1);
    let second = Number(arg2);
    let third = Number(arg3);

    let sum = first + second + third;
    let minutes = parseInt(sum / 60);
    let seconds = sum % 60;

    minutes = minutes.toString();
    seconds = seconds.toString();

    if (seconds < 10) {
        seconds = "0" + seconds;
    }
    console.log(`${minutes}:${seconds}`);
}

/* 
sumSeconds(["35", "45", "44"]);
sumSeconds(["22", "7", "34"]);
sumSeconds(["50", "50", "49"]);
    */