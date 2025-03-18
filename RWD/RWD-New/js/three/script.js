const table = document.getElementById('table');
const row = document.getElementById('row');
const data = document.getElementById('data');

var i=1,j=1;

for(i=1;i<=10;i++){
    let row = table.insertRow();
    for(j=1;j<=10;j++)
    {
        // document.write((i*j) + " ");
        let cell = row.insertCell();
        cell.innerText = i*j;
    }
    // document.write("<br>");
}