function Solve(input) {

    const resultObject = {};

    for (let index = 0; index < input.length; index++) {

        let splitedArray = input[index].split(' <-> ');
        let town = splitedArray[0];
        let townValue = Number(splitedArray[1]);


        if (!resultObject.hasOwnProperty(town)) {
            resultObject[town] = townValue;
        } else {
            resultObject[town] += townValue;
        }

    }

    for (const [key, value] of Object.entries(resultObject)) {

        console.log(`${key} : ${value}`)
    }

}

Solve(['Sofia <-> 1200000',
    'Washington <-> 1200000',
    'Varna <-> 1200000',
    'Burgas <-> 1200000',
    'Sofia <-> 1200000'
]);