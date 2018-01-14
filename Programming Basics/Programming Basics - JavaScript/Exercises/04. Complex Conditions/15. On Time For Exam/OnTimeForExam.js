function onTimeForExam([arg1, arg2, arg3, arg4]) {
    let hourExam = Number(arg1);
    let minutesExam = Number(arg2);
    let hourArrived = Number(arg3);
    let minutesArrived = Number(arg4);

    let timeExamInMinutes = (hourExam * 60) + minutesExam;
    let timeArrivedInMinutes = (hourArrived * 60) + minutesArrived;

    let timeArrived = timeExamInMinutes - timeArrivedInMinutes;
    let hours = parseInt(timeArrived / 60);
    let minutes = timeArrived % 60;

    if (timeArrived == 0 || timeArrived > 0 && timeArrived <= 30) {
        if (minutes == 0) {
            console.log("On time");
        } 
        else {
            console.log("On time");
            console.log(`${minutes} minutes before the start`);
        }
    }

    else if (timeArrived > 30) {
        if (hours == 0) {
            console.log("Early");
            console.log(`${minutes} minutes before the start`);
         }
        else {
            if (Math.abs(minutes) < 10) {
                console.log("Early");
                console.log(`${hours}:0${minutes} hours before the start`);
            }
            else {
                console.log("Early");
                console.log(`${hours}:${minutes} hours before the start`);
            }
        } 
    }
    
    else {
        if (hours == 0) {
            console.log("Late");
            console.log(`${Math.abs(minutes)} minutes after the start`);
        }
        else {
            if (Math.abs(minutes) < 10) {
                console.log("Late");
                console.log(`${Math.abs(hours)}:0${Math.abs(minutes)} hours after the start`);
            }
            else {
                console.log("Late");
                console.log(`${Math.abs(hours)}:${Math.abs(minutes)} hours after the start`);
            }
        }
    }   
}

/* Uncomment to test:
onTimeForExam(["9", "30", "9", "50"]);
onTimeForExam(["9", "00", "8", "30"]);
onTimeForExam(["16", "00", "15", "00"]);
    */