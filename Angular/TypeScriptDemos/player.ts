export class Player{
    playerId:number;
    playerName:string;
    country:string;
    numMatchesPlayed:number;

    constructor(id:number,name:string,country:string,matches:number) {
        this.playerId = id;
        this.playerName = name;
        this.country = country;
        this.numMatchesPlayed = matches;        
    }

    DisplayInfo():void{
        console.log(`Player Id = ${this.playerId} \n Player Name = ${this.playerName} \n Country = ${this.country}
            Matches played = ${this.numMatchesPlayed}`);
    }

}
