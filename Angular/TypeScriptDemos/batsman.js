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
exports.Batsman = void 0;
var player_1 = require("./player");
var Batsman = /** @class */ (function (_super) {
    __extends(Batsman, _super);
    function Batsman(id, name, country, matches, numRuns) {
        var _this = _super.call(this, id, name, country, matches) || this;
        _this.numRuns = numRuns;
        return _this;
    }
    Batsman.prototype.DisplayInfo = function () {
        _super.prototype.DisplayInfo.call(this);
        console.log("Runs scored = ".concat(this.numRuns));
    };
    return Batsman;
}(player_1.Player));
exports.Batsman = Batsman;
