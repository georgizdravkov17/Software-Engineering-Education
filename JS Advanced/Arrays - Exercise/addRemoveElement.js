function solve(commands) {

    let resultArray = [];
    let elementToPush = 0;

    for (const currentCommand of commands) {
        if (currentCommand === 'add') {
            elementToPush++;
            resultArray.push(elementToPush);
        } else if (currentCommand === 'remove') {
            if (resultArray.length > 0) {
                resultArray.pop();
                elementToPush++;
            }
        }
    }

    resultArray.length > 0 ? resultArray.forEach(element => {
        console.log(element);
    }) : console.log('Empty');

}

solve([
    'remove',

]);