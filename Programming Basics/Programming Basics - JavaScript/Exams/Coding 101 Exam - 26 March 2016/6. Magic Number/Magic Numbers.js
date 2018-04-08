function magicNummbers([arg1]) {
    let magic = Number(arg1);
    var magicNumber = "";
    for (let d1 = 0; d1 <= 9; d1++) {
        for (let d2 = 0; d2 <= 9; d2++) {
            for (let d3 = 0; d3 <= 9; d3++) {
                for (let d4 = 0; d4 <= 9; d4++) {
                    for (let d5 = 0; d5 <= 9; d5++) {
                        for (let d6 = 0; d6 <= 9; d6++) {
                            if (d1 * d2 * d3 * d4 * d5 * d6 == magic) {
                                magicNumber += (`${d1}${d2}${d3}${d4}${d5}${d6} `);
                            }
                        }
                    }
                }
            }
        }
    }
    console.log(magicNumber);
}

/* Uncomment to test:
magicNummbers(["8"]);
    */
  