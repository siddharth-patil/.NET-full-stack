function printBookInfo(bookcode, title, author, price, discount) {
    console.log("Book code is ".concat(bookcode));
    console.log("Book title is ".concat(title));
    console.log("Book author is ".concat(author));
    console.log("Book price is ".concat(price));
    if (discount == null) {
    }
    else {
        console.log("Discount on book is ".concat(discount));
    }
}
printBookInfo(1, "book1", "author1", 400);
printBookInfo(2, "book2", "author2", 400, 15);
