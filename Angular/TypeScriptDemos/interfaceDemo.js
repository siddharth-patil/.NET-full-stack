var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Student = /** @class */ (function () {
    /**
     *
     */
    function Student(rollno, name, marks) {
        this.rollno = rollno;
        this.name = name;
        this.marks = marks;
    }
    Student.prototype.Display = function () {
        console.log("Student name: ".concat(this.name, "\n Roll number: ").concat(this.rollno, " \n Marks: ").concat(this.marks));
    };
    return Student;
}());
var Products = /** @class */ (function () {
    function Products(id, name, price) {
        this.productId = id;
        this.productName = name;
        this.price = price;
    }
    Products.prototype.Display = function () {
        console.log("Product name: ".concat(this.productName, "\n Product ID: ").concat(this.productId, "\nPrice: ").concat(this.price));
    };
    return Products;
}());
var Employee = /** @class */ (function () {
    function Employee(id, name, sal) {
        this.empId = id;
        this.empName = name;
        this.salary = sal;
    }
    Employee.prototype.Display = function () {
        console.log("Emp Id: ".concat(this.empId, "\nEmp Name:").concat(this.empName, "\nSalary: ").concat(this.salary));
    };
    return Employee;
}());
var Manager = /** @class */ (function (_super) {
    __extends(Manager, _super);
    function Manager(id, name, sal, incentive) {
        var _this = _super.call(this, id, name, sal) || this;
        _this.incentive = incentive;
        return _this;
    }
    Manager.prototype.Display = function () {
        _super.prototype.Display.call(this);
        console.log(this.empName + "received Rs." + this.incentive + "bonus.");
    };
    return Manager;
}(Employee));
var arr = [];
var stdObj = new Student(1, "Sid", [99, 98, 100]);
// stdObj.Display();
arr.push(stdObj);
arr.push(new Products(12, "Bat", 12000));
for (var _i = 0, arr_1 = arr; _i < arr_1.length; _i++) {
    var element = arr_1[_i];
    element.Display();
    console.log('---------------');
}
