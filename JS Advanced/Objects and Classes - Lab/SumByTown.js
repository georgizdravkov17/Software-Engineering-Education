function Solve(input) {
    let obj = {};

    for (let index = 0; index < input.length; index++) {

        if (index % 2 === 0) {

            let town = input[index];
            let townValue = Number(input[index + 1]);

            if (!obj.hasOwnProperty(town)) {
                obj[town] = townValue;
            } else {
                obj[town] += townValue;
            }

        }

    }



    console.log(JSON.stringify(obj));
}


Solve(['Sofia', '20', 'Varna', '30', 'Varna', '100']);