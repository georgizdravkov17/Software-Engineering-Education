function Solve(number) {
    let numberToString = String(number);

    var sum = Number(numberToString[0]);;
    var counterOfSameElements = 1;

    var firstElement = numberToString[0];


    for (let index = 1; index < numberToString.length; index++) {

        let currentElement = (numberToString[index]);
        sum += Number(currentElement);

        if (firstElement === currentElement) {
            counterOfSameElements++;
        }

    }

    if (counterOfSameElements === numberToString.length) {
        console.log('true');
        console.log(sum);
    } else {
        console.log('false');
        console.log(sum);
    }
}


Solve(22223);