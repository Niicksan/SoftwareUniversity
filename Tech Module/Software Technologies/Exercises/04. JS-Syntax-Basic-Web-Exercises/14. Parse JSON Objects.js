function json(arr) {
    for (let line of arr){
        let obj = JSON.parse(line);
        for (let key in obj) {
            console.log(key[0].toUpperCase() + key.substring(1) + ": " + obj[key]);
        }
    }
}

json(['{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'
]);