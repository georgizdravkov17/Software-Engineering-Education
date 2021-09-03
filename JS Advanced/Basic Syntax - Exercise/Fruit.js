function Solve(fruit, weight, price) {
    let weightInKilograms = weight / 1000;

    let sum = weightInKilograms * price;

    console.log(`I need $${sum.toFixed(2)} to buy ${weightInKilograms.toFixed(2)} kilograms ${fruit}.`)


}

Solve('orange', 2500, 1.80);