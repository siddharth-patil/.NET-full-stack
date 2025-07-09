interface IPrintable{
    Display():void;
}

class Student implements IPrintable{
    rollno:number;
    name:string;
    marks:number[];

    /**
     *
     */
    constructor(rollno:number,name:string,marks:number[]) {
       this.rollno = rollno;
       this.name = name;
       this.marks = marks;        
    }

    Display(): void {
        console.log(`Student name: ${this.name}\n Roll number: ${this.rollno} \n Marks: ${this.marks}`);
    }
}

class Products implements IPrintable{
    productId:number;
    productName:string;
    price:number;

    constructor(id:number,name:string,price:number){
        this.productId = id;
        this.productName = name;
        this.price = price;
    }

    Display(): void {
        console.log(`Product name: ${this.productName}\n Product ID: ${this.productId}\nPrice: ${this.price}`);
    }

}

class Employee implements IPrintable{
    empId:number;
    empName:string;
    salary:number;

    constructor(id:number,name:string,sal:number){
        this.empId = id;
        this.empName = name;
        this.salary = sal;
    }

    Display(): void {
        console.log(`Emp Id: ${this.empId}\nEmp Name:${this.empName}\nSalary: ${this.salary}`);
    }

}

class Manager extends Employee implements IPrintable{
    incentive:number;

    constructor(id:number,name:string,sal:number,incentive:number){
        super(id,name,sal);
        this.incentive = incentive;
    }

    Display(): void {
        super.Display();
        console.log(this.empName + "received Rs." + this.incentive + "bonus.");
    }
}

let arr:IPrintable[]=[];

const stdObj = new Student(1,"Sid",[99,98,100]);

// stdObj.Display();

arr.push(stdObj);
arr.push(new Products(12,"Bat",12000));

for (const element of arr) {
    element.Display();
    console.log('---------------');
}