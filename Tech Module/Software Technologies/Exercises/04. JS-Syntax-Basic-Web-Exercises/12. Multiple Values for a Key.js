function multiplayValue(arr) {
    let result = {};
    let keyToFind = arr[arr.length - 1];

    for (let i = 0; i <arr.length - 1; i++) {
        let pair = arr[i].split(' ');

        let key = pair[0];
        let value = pair[1];

        if (result[key] === undefined) {
            result[key] = [];
            result[key].push(value)
        } else {
            result[key].push(value)
        }
    }

    if (result[keyToFind] === undefined) {
        console.log("None")
    } else {
        let values = result[keyToFind];
        for (let value of values) {
            console.log(value)
        }
    }
}

multiplayValue(['key value',
    'key eulav',
    'test test',
    '3 test',
    '3 test1',
    'key']);