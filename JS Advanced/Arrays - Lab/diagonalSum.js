function solve(matrix) {
    let firstDiagonal = 0;
    let secondDiagonal = 0;



    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            let secondDiagonalNeededIndex = matrix[row].length;
            if (row === col) {
                firstDiagonal += matrix[row][col];
            } else if (col === secondDiagonalNeededIndex) {
                secondDiagonal += matrix[row][col];
                secondDiagonalNeededIndex--;
            }

        }
    }

    console.log(firstDiagonal);
    console.log(secondDiagonal);

}

solve([
    [20, 40],
    [10, 60]
]);