function solve(numbers, step) {

    let resultArray = [];
    for (let index = 0; index < numbers.length; index += step) {
        resultArray.push(numbers[index]);
    }

    return resultArray;
}

console.log(solve(['1',
        '2',
        '3',
        '4',
        '5'
    ],
    6));