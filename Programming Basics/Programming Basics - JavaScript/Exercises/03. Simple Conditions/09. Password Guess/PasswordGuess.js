function guessThePassword([arg1]) {
    let password = arg1;

    if (password == "s3cr3t!P@ssw0rd") {
        console.log("Welcome");
    }

    else {
        console.log("Wrong password!");
    }
}

/* Uncomment to test:
guessThePassword(["qwerty"]);
guessThePassword(["s3cr3t!P@ssw0rd"]);
guessThePassword(["s3cr3t!p@ss"]);
    */