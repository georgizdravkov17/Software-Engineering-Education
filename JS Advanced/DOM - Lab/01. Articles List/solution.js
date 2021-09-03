function createArticle() {

    const title = document.querySelector("#createTitle");
    const text = document.querySelector("#createContent");

    const articleSection = document.querySelector("#articles");

    if (title.value === '' || text.value === '') {
        return;
    } else {
        const heading = document.createElement("h3").
        innerHTML(title);

        const content = document.createElement("p").
        innerHTML(text);

        const article = document.createElement("article");
        document.article.appendChild(heading);
        document.article.appendChild(content);

        document.articleSection.appendChild(article);

        title.value = '';
        text.value = '';
    }
}