function Solve(array) {


    if (array.length === 0) {
        return;
    } else if (array.length === 1) {
        return Number(array[0] * 2);
    }


    let firstElement = Number(array.shift());
    let lastElement = Number(array.pop());

    let sum = firstElement + lastElement;

    return sum;
}

console.log(Solve(['10']));