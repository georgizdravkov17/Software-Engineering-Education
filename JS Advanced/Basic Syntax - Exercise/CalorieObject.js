function Solve(input) {

    let object = {};

    for (let index = 0; index < input.length; index++) {
        if (index % 2 == 0) {

            object[input[index]] = Number([input[index + 1]]);

        }

    }

    console.log(object);
}

Solve(['Yogurt', '48', 'Rise', '30']);