export class FoodDish{
    image:string;
    dishName:string;
    foodType:string;
    cuisine:string;
    price:number;


    constructor(img:string,dn:string,fType:string,csn:string,price:number){
        this.image = img;
        this.dishName = dn;
        this.foodType = fType;
        this.cuisine = csn;
        this.price = price;
    }

}