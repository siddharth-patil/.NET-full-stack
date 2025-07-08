function printMarksheet (roll:number, name:string, marks:number[]){

    // let total = 0;
    // for (const element of marks) {
    //     total += element;
    // }
    // let percentage = (total/(marks.length*100))*100;

    console.log(`Roll no = ${roll}`);
    console.log(`Student name = ${name}`);
    console.log(`Marks = ${marks}`);
    
    let total:number = calTotal(marks);
    console.log(`Total = ${total}`);

    let percentage = calPercentage(total,marks.length);
    console.log(`Percentage = ${percentage}`);

}

function calTotal (marks:number[]){
    let total = 0;
    for (const element of marks) {
        total += element;
    }
    // console.log(`Total = ${total}`);
    return total;
}

function calPercentage(total:number, totalSub:number){
    let percentage = (total/(totalSub*100))*100;
    return percentage;
}

printMarksheet(121,"Siddharth", [98,100,100,99,92,86]);
printMarksheet(101,"Sam",  [78, 85, 90, 88, 76]);