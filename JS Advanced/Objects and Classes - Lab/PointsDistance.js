class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(firstPoint, secondPoint) {
        let result = Math.sqrt((firstPoint.x - secondPoint.x) ** 2 + (firstPoint.y - secondPoint.y) ** 2);
        return result;
    }
}

let y = new Point(5, 5);
let x = new Point(9, 8);
console.log(Point.distance(x, y));