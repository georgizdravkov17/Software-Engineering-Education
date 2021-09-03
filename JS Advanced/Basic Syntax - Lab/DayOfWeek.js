function Solve(input) {

    let dayOfWeek = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Sunday', 'Saturday'];

    if (dayOfWeek.includes(input)) {
        console.log(dayOfWeek.indexOf(input) + 1);
    } else {
        console.log("error")
    }



}

Solve('Friday');