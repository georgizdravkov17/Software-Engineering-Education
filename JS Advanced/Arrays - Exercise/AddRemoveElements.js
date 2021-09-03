function Solve(inputArray) {

    let resultArray = [];


    for (let index = 0; index < inputArray.length; index++) {

        let currentValue = index + 1;

        if (inputArray[index] === 'add') {
            resultArray.push(currentValue);

            currentValue++;

        } else if (inputArray[index] === 'remove') {
            resultArray.pop();
        }

    }


    if (resultArray.length === 0) {
        console.log('Empty');
    }

    console.log(resultArray.join('\n'));

}

Solve(['add', 'add', 'add', 'add']);