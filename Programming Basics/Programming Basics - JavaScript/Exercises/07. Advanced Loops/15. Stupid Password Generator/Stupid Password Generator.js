function stupidPasswordGenerator([arg1, arg2]) {
    let n = Number(arg1);
    let l = Number(arg2);

    for (let first = 1; first <= n; first++) {
        for (let second = 1; second <= n; second++) {
            for (var third = 'v'; third < 'z'; third++) {
                for (var fourth = 'c'; fourth < 'z'; fourth++) {
                    for (let fifth = Math.max(first, second) + 1; fifth <= n; fifth++) {
                        console.log(`${first}${second}${third}${fourth}${fifth} `);  
                    }
                }
            }
        }
    }
}

stupidPasswordGenerator(["7", "8"]);