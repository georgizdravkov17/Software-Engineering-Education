function Solve(array) {

    let resultArray = [];

    for (let index = 0; index < array.length; index++) {

        if (index % 2 === 0) {
            resultArray.push(array[index]);
        }

    }

    console.log(resultArray.join(' '));

}


Solve(['10', '20', '30']);