function solve(inputArray) {
    let sum = 0;
    let qSum = 0;
    let concat = '';

    for (let i = 0; i < inputArray.length; i++) {

        let currentNumber = inputArray[i];
        sum += currentNumber
        concat += currentNumber;
        qSum += 1 / currentNumber;

    }

    console.log(sum);
    console.log(qSum);
    console.log(concat);
}

solve([1, 2, 3]);