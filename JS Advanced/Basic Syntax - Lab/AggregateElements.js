function Solve(arr) {

    let sum = 0;
    let result = 0;
    let concatSum = '';

    for (let index = 0; index < arr.length; index++) {

        sum += Number(arr[index]);
        result += Number(1 / arr[index]);
        concatSum += arr[index];
    }

    console.log(sum);
    console.log(result);
    console.log(concatSum);

}

Solve([1, 2, 3]);