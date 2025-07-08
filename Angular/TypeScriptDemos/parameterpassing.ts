function printBookInfo(bookcode:number, title:string, author:string, price:number, discount?:number){

    console.log(`Book code is ${bookcode}`);
    console.log(`Book title is ${title}`);
    console.log(`Book author is ${author}`);
    console.log(`Book price is ${price}`);

    if (discount == null) {
        
    }
    else{
        console.log(`Discount on book is ${discount}`);
    }
    console.log("\n");
}

printBookInfo(1,"book1","author1",400);
printBookInfo(2,"book2","author2",400,15);