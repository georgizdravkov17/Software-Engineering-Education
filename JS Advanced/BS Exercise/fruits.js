function solve(typeOfFood, weightInGrams, pricePerKilogram) {

    let weightInKilograms = weightInGrams / 1000;

    let price = weightInKilograms * pricePerKilogram;

    console.log(`I need $${price.toFixed(2)} to buy ${weightInKilograms.toFixed(2)} kilograms ${typeOfFood}.`);
}

solve('orange', 2500, 1.80);
solve('apple', 1563, 2.35);