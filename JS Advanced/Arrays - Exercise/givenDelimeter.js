function solve(array, delimeter) {
    let resultString = '';
    for (const currentElement of array) {
        resultString += currentElement + delimeter;
    }

    console.log(resultString)
}

solve(['One', 'Two', 'Three', 'Four', 'Five'], '-');