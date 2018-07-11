function addRemove(args) {
    let arr = [];

    for (let operations of args) {
        let commands = operations.split(' ');
        let operation = commands[0];
        let number = commands[1];
        let index = commands[1];

        if (operation == "add") {
            arr.push(number);
        }
        else if (operation == "remove") {
            arr.splice(index, 1);
        }
    }

    for (let number of arr) {
        console.log(number);
    }
}

addRemove(['add 3', 'add 5', 'remove 2', 'remove 0', 'add 7']);