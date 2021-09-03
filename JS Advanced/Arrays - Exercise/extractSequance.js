function solve(numbers) {

    const encreasingSequance = [];
    let biggestElement = Number.MIN_VALUE;
    for (const currentNumber of numbers) {
        if (currentNumber > biggestElement) {
            encreasingSequance.push(currentNumber);
            biggestElement = currentNumber;
        }
    }

    encreasingSequance.forEach(element => {
        console.log(element);
    })

}

solve([20,
    3,
    2,
    15,
    6,
    1
]);