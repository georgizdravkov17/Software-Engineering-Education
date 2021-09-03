function Solve(arr) {


    const stepIndex = Number(arr.pop());

    for (let index = 0; index < arr.length; index += stepIndex) {
        console.log((arr[index]));
    }

}