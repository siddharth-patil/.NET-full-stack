import {Shape,Circle,Rectangle,Square} from './shape';

let circle:Circle = new Circle(50);
let rect:Rectangle = new Rectangle(5,14);
let sqr:Square = new Square(5);

let arr:Shape[] = [circle,rect,sqr];

arr.forEach(element => {
   element.calArea(); 
});
