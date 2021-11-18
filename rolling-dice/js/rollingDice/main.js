console.log("Let's roll some dice, baby")
console.log("------------------")

function Roll(input) {
    return {
        rollNum: input,
        rollString: numToString(input)
    }
}

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function numToString(input) {
    let dieString = ""
    switch (input) {
        case 1:
            dieString = "one"; // These \uXXXX values are fancy unicode characters
            break;
        case 2:
            dieString = "two";
            break;
        case 3:
            dieString = "three";
            break;
        case 4:
            dieString = "four";
            break;
        case 5:
            dieString = "five";
            break;
        case 6:
            dieString = "six";
            break;
    }

    return dieString;
}

for (let i = 0; i < 10; i++) {
    let die1 = Roll(getRandomInt(1, 6))
    let die2 = Roll(getRandomInt(1, 6))

    let message = `${die1.rollString} + ${die2.rollString} == ${die1.rollNum + die2.rollNum}`;
    if (die1.rollNum === die2.rollNum) {
        message += " DOUBLES!";
    }

    console.log(message);
}
