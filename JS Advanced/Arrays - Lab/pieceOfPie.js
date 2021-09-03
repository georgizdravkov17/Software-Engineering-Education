function solve(arr, startPhrase, endPhrase) {

    let startPhraseIndex = arr.indexOf(startPhrase);
    let endPhraseIndex = arr.indexOf(endPhrase);

    const resultArray = [];

    for (let index = startPhraseIndex; index <= endPhraseIndex; index++) {
        resultArray.push(arr[index]);
    }
    console.log(resultArray);

}

solve(['Josh', 'Ivan', 'Georgi', 'Todor', 'Pesho'], 'Ivan', 'Pesho');