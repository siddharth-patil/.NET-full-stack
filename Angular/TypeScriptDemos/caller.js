"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var batsman_1 = require("./batsman");
var bowler_1 = require("./bowler");
var team = [];
var b1 = new batsman_1.Batsman(1001, "Virat", "India", 269, 15000);
var b2 = new batsman_1.Batsman(1002, "Sachin", "India", 301, 16000);
var b3 = new bowler_1.Bowler(1003, "Jasprit", "India", 99, 200);
var b4 = new bowler_1.Bowler(1004, "Jaddu", "India", 90, 150);
team = [b1, b2, b3, b4];
team.push(new batsman_1.Batsman(1005, "Shubhman", "India", 50, 4000));
for (var _i = 0, team_1 = team; _i < team_1.length; _i++) {
    var player = team_1[_i];
    player.DisplayInfo();
    console.log('------------------');
}
