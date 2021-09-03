function Solve(array) {

    let resultArray = [];

    for (let index = 0; index < array.length; index++) {

        if (array[index] < 0) {
            resultArray.unshift(array[index]);
        } else {
            resultArray.push(array[index]);
        }

    }

    console.log(resultArray.join('\n'));

}

Solve(['7', '-2', '9', '8']);