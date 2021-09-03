function solve(currentSpeed, area) {
    let motorwayMaxSpeed = 130;
    let interstateMaxSpeed = 90;
    let cityMaxSpeed = 50;
    let residentialMaxSpeed = 20;





    if (area === 'motorway') {
        if (currentSpeed <= motorwayMaxSpeed) {
            console.log(`Driving ${currentSpeed} km/h in a ${motorwayMaxSpeed} zone`);
        } else {
            let difference = currentSpeed - motorwayMaxSpeed;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorwayMaxSpeed} - {status}`);
        }


    } else if (area === 'interstate') {
        if (currentSpeed <= motorwayMaxSpeed) {
            console.log(`Driving ${currentSpeed} km/h in a ${interstateMaxSpeed} zone`);
        } else {
            let difference = currentSpeed - interstateMaxSpeed;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstateMaxSpeed} - {status}`);
        }
    } else if (area === 'city') {
        if (currentSpeed <= cityMaxSpeed) {
            console.log(`Driving ${currentSpeed} km/h in a ${cityMaxSpeed} zone`);
        } else {
            let difference = currentSpeed - cityMaxSpeed;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${cityMaxSpeed} - {status}`);
        }

    } else if (area === 'residential') {
        if (currentSpeed <= residentialMaxSpeed) {
            console.log(`Driving ${currentSpeed} km/h in a ${residentialMaxSpeed} zone`);
        } else {
            let difference = currentSpeed - residentialMaxSpeed;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residentialMaxSpeed} - {status}`);
        }

    }

}

solve(40, 'city');
console.log('-------------');
solve(21, 'residential');
console.log('-------------');
solve(120, 'interstate');
console.log('-------------');
solve(200, 'motorway');