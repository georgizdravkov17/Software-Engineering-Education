function extractText() {
    let ul = document.getElementById('items');
    let textAreaContent = document.getElementById('result').value;
    let li = document.createElement('li');
    li.innerText = textAreaContent;
    ul.appendChild(li);

    document.getElementById('result').value = '';

}