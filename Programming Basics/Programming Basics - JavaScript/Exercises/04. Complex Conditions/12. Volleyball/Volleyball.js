function calculateVolleyballGames([arg1, arg2, arg3]) {
    let year = arg1;
    let holidays = Number(arg2);
    let weekednsOutOfTown = Number(arg3);

    let leap = 1;

    let weekendInSofia = 48 - weekednsOutOfTown;
    let gamesInSofia = weekendInSofia * 3 / 4;
    let gamesInHolidays = holidays * 2 / 3;

    let totalGamesPlayed = gamesInSofia + gamesInHolidays + weekednsOutOfTown;

    if (year == "leap") {
        console.log(Math.floor(totalGamesPlayed + (totalGamesPlayed * 0.15)));
    }

    else {
        console.log(Math.floor(totalGamesPlayed));
    }  
}

/* Uncomment to test:
calculateVolleyballGames(["leap", "5", "2"]);
calculateVolleyballGames(["normal", "3", "2"]);
calculateVolleyballGames(["leap", "2", "3"]);
calculateVolleyballGames(["normal", "11", "6"]);
    */
