function calculate1000DaysAfterBirth([arg1]) {
    let birth = arg1.toString().split('-');
    let birthDate = new Date(birth[2], birth[1] - 1, birth[0]);
    birthDate.setDate(birthDate.getDate() + 999);

    let thousandDaysAfterBirth = "";
    if (birthDate.getDate() < 10) {
        thousandDaysAfterBirth += "0";
    }
    thousandDaysAfterBirth += (birthDate.getDate().toString() + "-");

    if (birthDate.getMonth() < 10) {
        thousandDaysAfterBirth += "0";
    }
    thousandDaysAfterBirth += ((birthDate.getMonth() + 1).toString() + "-");

    let yearLength = birthDate.getFullYear().toString().length;
    for (let i = 1; i <= 4 - yearLength; i++) {
        thousandDaysAfterBirth += "0";
    }
    thousandDaysAfterBirth += birthDate.getFullYear().toString();
    console.log(thousandDaysAfterBirth);
}

/*Uncomment to test:
calculate1000DaysAfterBirth(["25-02-1995"]);
calculate1000DaysAfterBirth(["07-11-2003"]);
calculate1000DaysAfterBirth(["30-12-2002"]);
calculate1000DaysAfterBirth(["01-01-2012"]);
calculate1000DaysAfterBirth(["14-06-1980"]);
*