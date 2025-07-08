function printMarksheet(roll, name, marks) {
    // let total = 0;
    // for (const element of marks) {
    //     total += element;
    // }
    // let percentage = (total/(marks.length*100))*100;
    console.log("Roll no = ".concat(roll));
    console.log("Student name = ".concat(name));
    console.log("Marks = ".concat(marks));
    var total = calTotal(marks);
    console.log("Total = ".concat(total));
    var percentage = calPercentage(total, marks.length);
    console.log("Percentage = ".concat(percentage));
}
function calTotal(marks) {
    var total = 0;
    for (var _i = 0, marks_1 = marks; _i < marks_1.length; _i++) {
        var element = marks_1[_i];
        total += element;
    }
    // console.log(`Total = ${total}`);
    return total;
}
function calPercentage(total, totalSub) {
    var percentage = (total / (totalSub * 100)) * 100;
    return percentage;
}
printMarksheet(121, "Siddharth", [98, 100, 100, 99, 92, 86]);
printMarksheet(101, "Sam", [78, 85, 90, 88, 76]);
