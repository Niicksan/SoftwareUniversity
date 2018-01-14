function timeAfter15Minutes([arg1, arg2]) {
    let hour = parseInt(arg1);
    let minutes = parseInt(arg2);

    let totalMinutes = hour * 60 + minutes + 15;

    hour = parseInt(totalMinutes / 60);
    minutes = totalMinutes % 60;

    if (hour == 24) {
        hour -= 24;
    }

    if (minutes < 10) {
        minutes = "0" + minutes;
    }
    console.log(`${hour}:${minutes}`);
}

timeAfter15Minutes("1", "46");
timeAfter15Minutes("0", "01");
timeAfter15Minutes("23", "59");
timeAfter15Minutes("11", "08");
timeAfter15Minutes("12", "49");