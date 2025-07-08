import {Player} from "./player";
export class Batsman extends Player{
    numRuns:number;

    constructor(id:number,name:string,country:string,matches:number,numRuns:number) {
        super(id,name,country,matches);
        this.numRuns = numRuns;
    }

    DisplayInfo(): void {
        super.DisplayInfo();
        console.log(`Runs scored = ${this.numRuns}`);
    }
}