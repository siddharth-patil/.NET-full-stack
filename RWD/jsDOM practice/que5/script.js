var h3 = document.querySelector('h3');

var btnStart = document.querySelector('#start');
var btnStop = document.querySelector('#stop');

var interval;

btnStart.addEventListener('click', function(){
    var count = 0;
    interval = setInterval(() => {
        h3.textContent = count;
        count++;
    }, 1000);

    // interval = setInterval(function() {
    //     h3.textContent = count;
    //     count++;
    // }, 1000);

})

btnStop.addEventListener('click', function(){
    clearInterval(interval);

})

