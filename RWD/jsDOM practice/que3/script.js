var inps = document.querySelectorAll('input[type="text"]');
var form = document.querySelector('form');
var h3 = document.querySelector('h3');

form.addEventListener("submit",function(event){
    event.preventDefault();

    for(let i=0; i<inps.length; i++){

        if(inps[i].value === ''){
            h3.textContent = "some fields are blank...can't proceed!";
            h3.style.color = "red";
            break;
        }
        else{
            h3.textContent = "";
            h3.style.color = "black";
        }

    }

})