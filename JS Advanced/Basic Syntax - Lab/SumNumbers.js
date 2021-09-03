function Solve(firstNumber, secondNumber) {

    let result = 0;
    let startIndex = Number(firstNumber);
    let endIndex = Number(secondNumber);


    for (let index = startIndex; index <= endIndex; index++) {
        result += index;

    }
    return result;

}