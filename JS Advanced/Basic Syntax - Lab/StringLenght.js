function Solve(firstString, secondString, thirdString) {

    let lengthSum = firstString.length + secondString.length + thirdString.length;

    let averageSum = Math.floor(lengthSum / 3);

    console.log(lengthSum);
    console.log(averageSum);

}

Solve('chocolate', 'ice cream', 'cake');