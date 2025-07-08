var array:number[] = [1,3,2,432,23,4,12,65,67,76];
let count:number = 0;

for (const element of array) {

    if (element % 2 ==0) {
        count++;
    }
}
console.log("Even numbers count is: " + count);