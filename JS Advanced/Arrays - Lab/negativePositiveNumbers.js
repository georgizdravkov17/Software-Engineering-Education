function solve(numbers) {
    const resultArray = [];

    for (const currentElement of numbers) {
        if (currentElement >= 0) {
            resultArray.push(currentElement);
        } else {
            resultArray.unshift(currentElement);
        }
    }

    console.log(resultArray.join('\n'));
}

solve([7, -2, 8, 9]);