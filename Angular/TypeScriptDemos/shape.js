"use strict";
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
Object.defineProperty(exports, "__esModule", { value: true });
exports.Square = exports.Rectangle = exports.Circle = exports.Shape = void 0;
var Shape = /** @class */ (function () {
    function Shape() {
    }
    return Shape;
}());
exports.Shape = Shape;
var Circle = /** @class */ (function (_super) {
    __extends(Circle, _super);
    function Circle(radius) {
        var _this = _super.call(this) || this;
        _this.radius = radius;
        return _this;
    }
    Circle.prototype.calArea = function () {
        var area = Math.PI * this.radius * this.radius;
        console.log("Circle area is ".concat(area.toFixed(2)));
    };
    return Circle;
}(Shape));
exports.Circle = Circle;
var Rectangle = /** @class */ (function (_super) {
    __extends(Rectangle, _super);
    function Rectangle(length, breadth) {
        var _this = _super.call(this) || this;
        _this.breadth = breadth;
        _this.length = length;
        return _this;
    }
    Rectangle.prototype.calArea = function () {
        var area = this.length * this.breadth;
        console.log("Rectangle area is ".concat(area.toFixed(2)));
    };
    return Rectangle;
}(Shape));
exports.Rectangle = Rectangle;
var Square = /** @class */ (function (_super) {
    __extends(Square, _super);
    function Square(side) {
        var _this = _super.call(this) || this;
        _this.side = side;
        return _this;
    }
    Square.prototype.calArea = function () {
        var area = this.side * this.side;
        console.log("Square area is ".concat(area.toFixed(2)));
    };
    return Square;
}(Shape));
exports.Square = Square;
