function solve(number) {

    let square = '';

    for (let row = 1; row <= number; row++) {

        square += '* ';
    }

    for (let row = 1; row <= number; row++) {

        console.log(square);
    }



}

solve(5);