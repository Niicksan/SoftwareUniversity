function keyValuePair(args) {
    let result = {};
    let keyToFind = args[args.length - 1];

    for (let i = 0; i < args.length - 1; i++) {
        let pair = args[i].split(' ');

        let key = pair[0];
        let value = pair[1];

        result[key] = value;
    }

    if (result[keyToFind] === undefined) {
        console.log("None")
    } else {
        console.log(result[keyToFind]);
    }
}

keyValuePair(['key value', 'key eulav', 'test test', '3 test', '3 test1','key']);