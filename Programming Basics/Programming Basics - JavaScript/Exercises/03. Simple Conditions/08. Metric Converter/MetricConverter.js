function metricConverter([arg1, arg2, arg3]) {
    let value = Number(arg1);
    let inputMetrics = arg2;
    let outputMetrics = arg3;

    let metricsInMeters = value;
    if (inputMetrics == "mm") {
        metricsInMeters = value / 1000;
    }

    else if (inputMetrics == "cm") {
        metricsInMeters = value / 100;
    }

    else if (inputMetrics == "mi") {
        metricsInMeters = value / 0.000621371192;
    }

    else if (inputMetrics == "in") {
        metricsInMeters = value / 39.3700787;
    }

    else if (inputMetrics == "km") {
        metricsInMeters = value / 0.001;
    }

    else if (inputMetrics == "ft") {
        metricsInMeters = value / 3.2808399;
    }

    else if (inputMetrics == "yd") {
        metricsInMeters = value / 1.0936133;
    }


    if (outputMetrics == "mm") {
        metricsInMeters *= 1000;
    }

    else if (outputMetrics == "cm") {
        metricsInMeters *= 100;
    }

    else if (outputMetrics == "mi") {
        metricsInMeters *= 0.000621371192;
    }

    else if (outputMetrics == "in") {
        metricsInMeters *= 39.3700787;
    }

    else if (outputMetrics == "km") {
        metricsInMeters *= 0.001;
    }

    else if (outputMetrics == "ft") {
        metricsInMeters *= 3.2808399;
    }

    else if (outputMetrics == "yd") {
        metricsInMeters *= 1.0936133;
    }

    console.log(`${metricsInMeters} ${outputMetrics}`);
}

/* Uncomment to test:
metricConverter(["12", "km", "ft"]);
metricConverter(["150", "mi", "in"]);
metricConverter(["450", "yd", "km"]);
metricConverter(["450", "m", "m"]);
    */