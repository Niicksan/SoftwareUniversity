function usdTtoBGN([arg1]) {
    let USD = parseFloat(arg1);
    let BGN = USD * 1.79549;

    console.log(`${BGN.toFixed(2)} BGN`);
}

/*Uncomment to test:
usdTtoBGN(["20"]);
usdTtoBGN(["100"]);
usdTtoBGN(["12.5"]);
*/