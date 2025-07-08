"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.Bowler = void 0;
var player_1 = require("./player");
var Bowler = /** @class */ (function (_super) {
    __extends(Bowler, _super);
    function Bowler(id, name, country, matches, numWickets) {
        var _this = _super.call(this, id, name, country, matches) || this;
        _this.numWickets = numWickets;
        return _this;
    }
    Bowler.prototype.DisplayInfo = function () {
        _super.prototype.DisplayInfo.call(this);
        console.log("Wickets taken " + this.numWickets);
    };
    return Bowler;
}(player_1.Player));
exports.Bowler = Bowler;
