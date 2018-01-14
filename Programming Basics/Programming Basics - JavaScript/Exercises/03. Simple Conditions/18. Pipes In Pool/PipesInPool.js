function pipesInPool([arg1, arg2, arg3, arg4]) {
    let v = Number(arg1);
    let pipe1 = Number(arg2);
    let pipe2 = Number(arg3);
    let hours = parseFloat(arg4);

    let litersPipe1 = pipe1 * hours;
    let litersPipe2 = pipe2 * hours;
    let litersFull = litersPipe1 + litersPipe2;

    let percentageFull = (litersFull / v) * 100;
    let percentagePipe1 = (litersPipe1 / litersFull) * 100;
    let percentagePipe2 = (litersPipe2 / litersFull) * 100;


    if (litersFull <= v) {
        console.log(`The pool is ${Math.floor(percentageFull)}% full. Pipe 1: ${Math.floor(percentagePipe1)}%. Pipe 2: ${Math.floor(percentagePipe2)}%.`);
    }
    
    else {
        console.log(`For ${hours} hours the pool overflows with ${(litersFull - v).toFixed(1)} liters.`)
    }
}

/* Uncomment to test:
pipesInPool(["1000", "100", "120", "3"]);
pipesInPool(["100", "100", "100", "2.5"]);
    */