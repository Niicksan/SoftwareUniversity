function calculateTilesAndTimeNeeded([n, w, l, m, o]) {
    let lengthGround = Number(n);
    let widthTiles = parseFloat(w);
    let lenghtTiles = parseFloat(l);
    let widthBench = parseFloat(m);
    let lenghtBench = parseFloat(o)

    let groundArea = lengthGround * lengthGround;
    let benchArea = widthBench * lenghtBench;
    let tilesArea = widthTiles * lenghtTiles;
    let tiledGroundArea = groundArea - benchArea;

    let tilesNeeded = tiledGroundArea / tilesArea;
    let timeNeeded = tilesNeeded * 0.2;

    console.log(tilesNeeded.toFixed(2));
    console.log(timeNeeded.toFixed(2));
}

/* Uncomment to test:
calculateTilesAndTimeNeeded(["20", "5", "4", "1", "2"]);
calculateTilesAndTimeNeeded(["40", "0.8", "0.6", "3", "5"]);
    */