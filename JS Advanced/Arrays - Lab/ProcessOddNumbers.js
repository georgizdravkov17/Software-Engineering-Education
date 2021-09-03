function Solve(array) {
    const resultArray = [];

    for (let index = 0; index < array.length; index++) {

        if (index % 2 !== 0) {
            resultArray.push(array[index] * 2)
        }
    }

    resultArray.reverse();

    console.log(resultArray.join(' '));
}

Solve(['10', '15', '20', '25']);