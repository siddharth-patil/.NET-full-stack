var array = [1, 3, 2, 432, 23, 4, 12, 65, 67, 76];
var count = 0;
for (var _i = 0, array_1 = array; _i < array_1.length; _i++) {
    var element = array_1[_i];
    if (element % 2 == 0) {
        count++;
    }
}
console.log("Even numbers count is: " + count);
