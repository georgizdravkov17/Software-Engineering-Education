function solve(number) {

    let numberToString = number.toString();
    let equalsDigitCount = 1;
    let firstLetter = numberToString[0];


    for (let index = 1; index < numberToString.length; index++) {

        if (numberToString[index] === firstLetter) {
            equalsDigitCount++;
        } else {
            break;
        }
    }

    let sumOfDigit = 0;

    for (let index = 0; index < numberToString.length; index++) {
        sumOfDigit += Number(numberToString[index]);
    }


    console.log(equalsDigitCount === numberToString.length ? true : false);
    console.log(sumOfDigit);
}

solve(2222222);
solve(1234);