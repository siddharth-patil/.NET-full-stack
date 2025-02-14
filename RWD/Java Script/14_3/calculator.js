function clearAll(){
    const a = document.getElementById('n1');
    a.value = "";

    const b = document.getElementById('n2');
    b.value = "";

    const ans = document.getElementById('ans');
    ans.value = "";
}

function add(){
    const a = document.getElementById('n1');
    let n1 = parseInt(a.value);

    const b = document.getElementById('n2');
    let n2 = parseInt(b.value);

    let op = n1 + n2;

    const ans = document.getElementById('ans');
    ans.value = op;
}

function subtract(){
    const a = document.getElementById('n1');
    let n1 = parseInt(a.value);

    const b = document.getElementById('n2');
    let n2 = parseInt(b.value);

    let op = n1 - n2;

    const ans = document.getElementById('ans');
    ans.value = op;
}

function multiply(){
    const a = document.getElementById('n1');
    let n1 = parseInt(a.value);

    const b = document.getElementById('n2');
    let n2 = parseInt(b.value);

    let op = n1 * n2;

    const ans = document.getElementById('ans');
    ans.value = op;
}

function divide(){
    const a = document.getElementById('n1');
    let n1 = parseInt(a.value);

    const b = document.getElementById('n2');
    let n2 = parseInt(b.value);

    let op = n1 / n2;

    const ans = document.getElementById('ans');
    ans.value = op;
}
