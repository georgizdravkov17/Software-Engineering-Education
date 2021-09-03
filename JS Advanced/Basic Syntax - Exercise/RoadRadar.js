function Solve(arr) {

    let speed = Number(arr[0]);
    let area = arr[1];
    let limitSpeed;


    if (area === 'motorway') {
        limitSpeed = 130;
    } else if (area === 'interstate') {
        limitSpeed = 90;
    } else if (area === 'city') {
        limitSpeed = 50;
    } else if (area === 'residential') {
        limitSpeed = 20;
    }

    let overLimit = Math.abs(limitSpeed - speed);

    if (overLimit > 0 && overLimit <= 20) {
        console.log('speeding')
    } else if (overLimit > 20 && overLimit <= 40) {
        console.log('excessive speeding');
    } else if (overLimit > 40) {
        console.log('reckless driving');
    }

}

Solve(120, 'motorway');