function addItem() {

    const textValue = document.getElementById('newItemText').value;

    var newHeading = document.createElement("h1").textContent(textValue);

    const article = document.getElementsByTagName('article');

    document.article.appendChild(newHeading);

}