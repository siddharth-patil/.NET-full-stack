

function calAreaOfCircle() {
    const radius = document.getElementById('radius');
    const ans = document.getElementById('ans');
    let area = parseFloat(radius.value) * parseFloat(radius.value) * 3.14;
    ans.value = area;
}

function calCircumOfCircle() {
    const radius = document.getElementById('radius');
    const ans = document.getElementById('ans');
    let circumference = parseFloat(radius.value) * 2 * 3.14;
    ans.value = circumference;
}