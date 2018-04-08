function stupidPasswordGenerator([arg1, arg2]) {
    let n = Number(arg1);
    let l = Number(arg2);

    for (let first = 1; first <= n; first++) {
        for (ch second = 1; second <= n; second++) {
            for (var third = 'a'; third < 'a' + l; third++) {
                for (var fourth = 'a'; fourth < 'a' + l; fourth++) {
                    for (let fifth = Math.max(first, second) + 1; fifth <= n; fifth++) {
                        console.log(`${first}${second}${third}${fourth}${fifth} `);
                    }
                }
            }
        }
    }
}

stupidPasswordGenerator(["3", "2"]);