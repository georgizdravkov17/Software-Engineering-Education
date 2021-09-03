function Solve(input) {

    let number = Number(input.shift());

    for (let index = 0; index < input.length; index++) {

        if (input[index] === 'chop') {
            number /= 2;
        } else if (input[index] === 'dice') {
            number = Math.sqrt(number);
        } else if (input[index] === 'spice') {
            number += 1;
        } else if (input[index] === 'bake') {
            number *= 3;
        } else if (input[index] === 'fillet') {
            number *= 0.8;
        }

        console.log(number);

    }
}


Solve(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);