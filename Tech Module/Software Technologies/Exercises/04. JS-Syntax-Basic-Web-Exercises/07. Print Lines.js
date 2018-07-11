function printLines(arr) {
    for (let i = 0; i < arr.length - 1 ; i++) {
        if (arr[i] != 'Stop') {
            console.log(arr[i]);
        }
        else {
            break;
        }
    }
}

printLines(['Line 1', 'Line 2', 'Line 3', 'Stop', '10', '12']);