function solve(input) {
    let towns = {};

    for (const currentTown of input) {
        let [townName, townPopulation] = currentTown.split(" <-> ");
        towns[townName] = townPopulation;
    }

    return towns
}

console.log(solve(['York <-> 12000', 'Burgas <-> 10000', 'Sofia <-> 15000', 'Plovdiv <-> 7000']));