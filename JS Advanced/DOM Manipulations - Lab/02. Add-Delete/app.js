function addItem() {

    const text = document.getElementById("newText");

    const items = document.getElementById("items");

    items.addEventListener("click", onClick);

    const newLi = document.createElement("li");
    newLi.innerHTML = `${text.value} <a href="#">[Delete]</a>`;

    document.getElementById("items").appendChild(newLi);

    text.value = '';

    function onClick(e) {
        const item = e.target.parentNode;
        item.remove();
    }
}