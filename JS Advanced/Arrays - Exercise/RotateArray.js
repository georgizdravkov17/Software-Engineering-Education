function Solve(arr) {

    const rotations = Number(arr.pop());

    for (let index = 0; index < rotations; index++) {

        currentLast = arr.pop();
        arr.unshift(currentLast);

    }


    console.log(arr.join(' '));

}

Solve(['1', '2', '3', '4', '2']);