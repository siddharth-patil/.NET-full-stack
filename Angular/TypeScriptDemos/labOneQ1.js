function SimpleInterest(principal, rate, time) {
    var SI = (principal * rate * time) / 100;
    console.log("Simple interest is ".concat(SI));
}
var p = 192000;
var rate = 10.25;
var t = 15;
SimpleInterest(p, rate, t);
