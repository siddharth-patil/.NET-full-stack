"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var shape_1 = require("./shape");
var circle = new shape_1.Circle(50);
var rect = new shape_1.Rectangle(5, 14);
var sqr = new shape_1.Square(5);
var arr = [circle, rect, sqr];
arr.forEach(function (element) {
    element.calArea();
});
