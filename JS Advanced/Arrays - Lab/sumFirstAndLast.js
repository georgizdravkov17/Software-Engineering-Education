function solve(numbers) {

    if (numbers.length >= 2) {
        let firstElement = Number(numbers[0]);
        let lastElement = Number(numbers[numbers.length - 1]);
        let sum = firstElement + lastElement;

        console.log(sum);
    }

}

solve(['10', '20']);
solve(['10', '20', '30']);