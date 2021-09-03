function solve(numbers) {
    numbers.sort((a, b) => a - b);

    const resultArray = [];

    let start = numbers.length % 2 === 0 ? numbers.length / 2 : (numbers.length / 2);

    for (let index = start; index < numbers.length; index++) {
        resultArray.push(numbers[index]);
    }

    console.log(resultArray);
}

solve([3, 19, 14, 7, 2, 19, 6]);
solve([2, 4, 7, 5, 1, 20]);