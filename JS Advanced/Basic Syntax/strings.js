function stringsLength(str1, str2, str3) {
    let inputLength = str1.length + str2.length + str3.length;
    let averageLength = Math.floor(inputLength / 3);

    console.log(inputLength);
    console.log(averageLength);

}

stringsLength('chocolate', 'ice cream', 'cake');