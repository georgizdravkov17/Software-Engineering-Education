function calc() {
    let firstInput = Number(document.getElementById('num1').value);
    let secondInput = Number(document.getElementById('num2').value);

    let thirdInput = document.getElementById('sum');

    thirdInput.value = firstInput + secondInput;

}