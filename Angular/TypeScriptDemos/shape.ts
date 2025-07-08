export abstract class Shape {
    
    abstract calArea():void;

}

export class Circle extends Shape{
    
    radius:number;

    constructor(radius:number){
        super();
        this.radius = radius;
    }

    calArea(): void {
        const area = Math.PI * this.radius * this.radius;
        console.log(`Circle area is ${area.toFixed(2)}`);
    }
}

export class Rectangle extends Shape{
    length:number;
    breadth:number;

    constructor(length:number, breadth:number)
    {
        super();
        this.breadth = breadth;
        this.length = length;
    }

    calArea(): void {
        const area = this.length * this.breadth;
        console.log(`Rectangle area is ${area.toFixed(2)}`);
    }
}

export class Square extends Shape{
    side:number;

    constructor(side:number)
    {
        super();
        this.side = side;
    }

    calArea(): void {
        const area = this.side * this.side;
        console.log(`Square area is ${area.toFixed(2)}`);
    }
}