function solve(names) {
    names.sort((a, b) => a.length - b.length || a.toLowerCase().localeCompare(b.toLowerCase().localeCompare))
        .forEach(element => {
            console.log(element);
        })

}

solve(['alpha',
    'beta',
    'gamma'
]);