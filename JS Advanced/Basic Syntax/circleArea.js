function area(input) {

    let inputType = typeof(input);

    if (inputType === Number) {
        let result = (Number(input) ** 2) * Math.PI;
        console.log(result.toFixed(2));

    } else {
        console.log(`We can not calculate the circle area, because we recieve a ${inputType}.`)
    }

}

area(5);