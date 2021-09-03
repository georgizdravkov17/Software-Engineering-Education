class Circle {
    constructor(radius) {
        this.radius = radius;
    }

    get diameter() {
        return this.radius * 2;
    }

    set diameter(value) {
        let diametar = value * 2;
    }

    area() {
        let area = Math.PI * Math.pow(this.radius);
        return area;
    }
}