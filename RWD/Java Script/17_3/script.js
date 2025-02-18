let pronoun = "He";
let courseName = '';
let module_ = "";
let centerName = '';
function getGender(elem){
    // console.log(elem)
    if(elem.id === "female"){
        pronoun = "She";
    }
    // console.log(pronoun);
}

function getCourse(elem){
    // console.log(elem.value)
    courseName = elem.value;
}
function getCenter(elem){
    // console.log(elem.value)
    centerName = elem.value;
}

function getModule(elem){
    // console.log(elem.name);
    module_ += elem.name + ', ';
}

function printData() {

    var p = document.querySelector('#output');

    var fname = document.querySelector('#fname');
    var lname = document.querySelector('#lname');
    // var gender = document.querySelectorAll('#gender');
    // var course = document.querySelectorAll('#course');
    // var modules = document.querySelectorAll('#modules');
    // var center = document.querySelectorAll('#center');
    var pct = document.querySelectorAll('#pct');

    let grade;
    if(parseInt(pct[0].value) > 90){
        grade = 'A';
    }else if (parseInt(pct[0].value) > 70){
        grade = 'B';
    }else if (parseInt(pct[0].value) > 50){
        grade = 'C';
    }else if (parseInt(pct[0].value) > 35){
        grade = 'pass grade';
    }else{
        grade = 'fail';
    }

    
    // gender.forEach(function(elem){
    //     if(elem.value === "Female"){
    //         pronoun = "She";
    //     }
    // })

    var outputText = `<p>Studen name is ${fname.value} ${lname.value}.</p> 
                        <p>${pronoun} enrolled for course ${courseName}.</p> 
                        <p>${pronoun} already done with these modules - ${module_}</p> 
                        <p>${pronoun} has taken admission to ${branch} branch.</p>
                        <p>${pronoun} has grade ${grade}</p>`;

    p.innerHTML = outputText;

}