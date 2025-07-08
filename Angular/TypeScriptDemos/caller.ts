import { Player } from "./player";
import { Batsman} from "./batsman";
import { Bowler } from "./bowler";

let team: Player[] = [];

let b1: Batsman = new Batsman(1001, "Virat", "India", 269, 15000);
let b2: Batsman = new Batsman(1002, "Sachin", "India", 301, 16000);
let b3: Bowler = new Bowler(1003, "Jasprit", "India", 99, 200);
let b4: Bowler = new Bowler(1004, "Jaddu", "India", 90, 150);

team = [b1, b2, b3, b4];

team.push(new Batsman(1005, "Shubhman", "India", 50, 4000));

for (const player of team) {
    player.DisplayInfo();
    console.log('------------------');
}