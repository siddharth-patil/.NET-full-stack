var carBrands:string[] = ["TATA","Mahindra","Mitsubishi","Honda","BMW"];

carBrands.push('Audi');
carBrands.push('Ford');
carBrands.push('Toyota');

carBrands.sort();
console.log("Sorted array\n");
for (let brand of carBrands) {
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

for (let index = 0; index < carBrands.length; index++) {
    let element = carBrands[index];
    console.log(element);
}