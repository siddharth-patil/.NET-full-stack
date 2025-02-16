// var home = document.querySelector('#home');
// var about = document.querySelector('#about');
// var contact = document.querySelector('#contact');

// var homeText = document.querySelector('#home-text');
// var aboutText = document.querySelector('#about-text');
// var contactText = document.querySelector('#contact-text');

// var main = document.querySelector('main');

// home.addEventListener('click',function(){
//     hideAllText();
//     homeText.style.display = 'block';
// });

// about.addEventListener('click',function(){
//     hideAllText();
//     aboutText.style.display = 'block';
// });

// contact.addEventListener('click',function(){
//     hideAllText();
//     contactText.style.display = 'block';
// });

// function hideAllText(){
//     homeText.style.display = 'none';
//     aboutText.style.display = 'none';
//     contactText.style.display = 'none';
// }

// Optimized logic
var lists = document.querySelectorAll('li');
var paras = document.querySelectorAll('p');

lists.forEach(function(li, index){
    
    li.addEventListener("click", function(){
        hideAllText();
        paras[index].style.display = 'block';
    })
});

function hideAllText(){
    paras.forEach(function (p){
        p.style.display = 'none';
    });
}

