import { Player } from "./player";
export class Bowler extends Player{
    numWickets:number;

    constructor(id:number,name:string,country:string,matches:number,numWickets:number) {
        super(id,name,country,matches);
        this.numWickets = numWickets;
    }

    DisplayInfo(): void {
        super.DisplayInfo();
        console.log("Wickets taken " +this.numWickets);
    }
}