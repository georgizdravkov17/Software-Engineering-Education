function solve(names) {
    let index = 1;
    names.sort((a, b) => a.localeCompare(b)).forEach(element => {
        console.log(`${index}.${element}`);
        index++;
    });

    console.log(names);
}

solve(["John", "Bob", "Christina", "Ema"]);