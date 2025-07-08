"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Player = void 0;
var Player = /** @class */ (function () {
    function Player(id, name, country, matches) {
        this.playerId = id;
        this.playerName = name;
        this.country = country;
        this.numMatchesPlayed = matches;
    }
    Player.prototype.DisplayInfo = function () {
        console.log("Player Id = ".concat(this.playerId, " \n Player Name = ").concat(this.playerName, " \n Country = ").concat(this.country, "\n            Matches played = ").concat(this.numMatchesPlayed));
    };
    return Player;
}());
exports.Player = Player;
