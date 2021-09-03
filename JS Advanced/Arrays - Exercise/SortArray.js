function Solv(arr) {

    const sortedArray = arr.sort((a, b) => a.length - b.length) ||
        arr.sort((a, b) => a.localCompare.upperCase(b.upperCase));

    console.log(sortedArray.join('\n'));
}