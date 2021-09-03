function solve(start, end) {

    let sum = 0;

    for (let i = Number(start); i <= Number(end); i++) {
        sum += i;
    }

    console.log(sum);

}

solve('1', '5');
solve('-8', '20');