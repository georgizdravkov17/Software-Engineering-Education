function solve(numbers) {

    let resultAsString = '';

    for (let index = 0; index < numbers.length; index++) {
        if (index % 2 === 0) {
            resultAsString += numbers[index] + ' ';

        }
    }

    console.log(resultAsString);
}

solve(['20', '30', '40', '50', '60']);