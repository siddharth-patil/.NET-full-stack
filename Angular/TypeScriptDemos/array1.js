var carBrands = ["TATA", "Mahindra", "Mitsubishi", "Honda", "BMW"];
carBrands.push('Audi');
carBrands.push('Ford');
carBrands.push('Toyota');
carBrands.sort();
console.log("Sorted array\n");
for (var _i = 0, carBrands_1 = carBrands; _i < carBrands_1.length; _i++) {
    var brand = carBrands_1[_i];
    console.log(brand);
}
carBrands.reverse();
console.log("\nReverse array\n");
// for (let brand of carBrands) {
//     console.log(brand);
// }
// for (let index = carBrands.length-1; index <=0; index--) {
//     console.log(carBrands[index] + "\n");    
// }
for (var index = 0; index < carBrands.length; index++) {
    var element = carBrands[index];
    console.log(element + "\n");
}
