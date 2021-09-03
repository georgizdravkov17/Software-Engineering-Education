function solve(num1, num2, num3) {

    var firstNumber = Number(num1);
    var secondNUmber = Number(num2);
    var thirdNumber = Number(num3);

    var largestNumber = Number.MIN_VALUE;

    if (firstNumber > secondNUmber && firstNumber > thirdNumber) {
        largestNumber = firstNumber;
    } else if (secondNUmber > firstNumber && secondNUmber > thirdNumber) {
        largestNumber = secondNUmber;
    } else {
        largestNumber = thirdNumber;
    }

    console.log(`The largest number is ${largestNumber}.`);


}

solve('3', '5', '-2');