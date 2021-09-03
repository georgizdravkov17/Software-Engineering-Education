function Solve(input) {

    const resultObject = {};

    for (let index = 0; index < input.length; index++) {
        let splittedArray = input[index].split(' | ');

        let townName = splittedArray[0];
        let productName = splittedArray[1];
        let productPrice = Number(splittedArray[2]);

        if (!resultObject.hasOwnProperty(townName)) {

            if (!townName.hasOwnProperty(productName)) {
                townName[productName] = productPrice;
            } else {
                townName[productName] += productPrice;
            }
        } else {

            if (!townName.hasOwnProperty(productName)) {
                townName[productName] = productPrice;
            } else {
                townName[productName] += productPrice;
            }
        }

    }

    console.log(resultObject);
}

Solve(['Sample Sofia | Sample Product | 1000', 'Sample Town | Sample Morkovi | 1000', 'Sample Town | Sample Product | 1000', 'Sample Varna | Sample Banani | 1000']);