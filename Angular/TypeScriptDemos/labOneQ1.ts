function SimpleInterest(principal:number, rate:number, time:number){
    let SI = (principal * rate * time)/100;

    console.log(`Simple interest is ${SI}`);
}

var p = 192000;
var rate = 10.25;
var t = 15;
SimpleInterest(p,rate,t);
