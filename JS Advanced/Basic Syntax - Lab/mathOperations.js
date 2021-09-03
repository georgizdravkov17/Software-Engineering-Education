function Solve(firstNumber, secondNumber, operator) {

    let result;
    switch (operator) {
        case '+':
            result = Number(firstNumber) + Number(secondNumber);
            break;
        case '-':
            result = Number(firstNumber) - Number(secondNumber);
            break;
        case '/':
            result = Number(firstNumber) / Number(secondNumber);
            break;
        case '*':
            result = Number(firstNumber) * Number(secondNumber);
            break;
        case '**':
            result = Number(firstNumber) ** Number(secondNumber);
            break;
        case '%':
            result = Number(firstNumber) % Number(secondNumber);
            break;
    }

    return result;
}

console.log(Solve('5', '6', '+'));