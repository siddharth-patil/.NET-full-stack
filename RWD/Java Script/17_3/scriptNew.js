var submit = document.querySelector('button');

submit.addEventListener('click',function(){
    let pronoun = "He";
    var fname = document.querySelector('#fname').value;
    var lname = document.querySelector('#lname').value;

    var gender = document.querySelector('input[name="gender"]:checked');

    if(gender.value === "Female"){
        pronoun = "She";
    }

    var course = document.querySelector('#course').value;

    var modules = [];

    document.querySelectorAll('input[type="checkbox"]:checked').forEach(elem =>{
        modules.push(elem.name);
    })

    var center = document.querySelector('#center').value;

    var pct = document.querySelector('#pct').value;

    let grade;
    if(parseInt(pct) > 90){
        grade = 'A';
    }else if (parseInt(pct) > 70){
        grade = 'B';
    }else if (parseInt(pct) > 50){
        grade = 'C';
    }else if (parseInt(pct) > 35){
        grade = 'pass grade';
    }else{
        grade = 'fail';
    }

    var outputText = `<p>Studen name is ${fname} ${lname}.</p> 
                        <p>${pronoun} enrolled for course ${course}.</p> 
                        <p>${pronoun} already done with these modules - ${modules}</p> 
                        <p>${pronoun} has taken admission to ${center} branch.</p>
                        <p>${pronoun} has grade ${grade}</p>`;

    document.querySelector('#output').innerHTML = outputText;


})