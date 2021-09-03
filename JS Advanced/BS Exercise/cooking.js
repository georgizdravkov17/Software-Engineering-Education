function solve(...args) {
    let [number, ...commands] = arguments;
    let numberAsDecimal = Number(number);



    for (const currentCommand of commands) {
        switch (currentCommand) {
            case 'chop':
                numberAsDecimal /= 2;
                break;
            case 'dice':
                numberAsDecimal = Math.sqrt(numberAsDecimal);
                break;
            case 'spice':
                numberAsDecimal += 1;
                break;
            case 'bake':
                numberAsDecimal *= 3;
                break;
            case 'fillet':
                numberAsDecimal *= 0.8;
                break;
        }

        console.log(numberAsDecimal);
    }
}

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');






/*
    • chop - divide the number by two
    • dice - square root of number
    • spice - add 1 to number
    • bake - multiply number by 3
    • fillet - subtract 20% from number
*/