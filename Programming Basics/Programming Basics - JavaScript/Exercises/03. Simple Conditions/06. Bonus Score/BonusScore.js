function bonusScore([arg1]) {
    let score = parseInt(arg1);
    let bonus = 0;

    if (score <= 100) {
        bonus += 5;
    }

    else if (score > 100 && score <= 1000) {
        bonus += score * 0.20;
    }

    else {
        bonus += score * 0.10;
    }

    if (score % 2 == 0) {
        bonus += 1;
    }

    else if (score % 5 == 0) {
        bonus += 2;
    }

    console.log(bonus);
    console.log(score + bonus);

}

/* Uncomment to test:
bonusScore(["20"]);
bonusScore(["175"]);
bonusScore(["2703"]);
bonusScore(["15875"]);
    */