"use strict";
exports.__esModule = true;
var Figures = /** @class */ (function () {
    function Figures() {
        this.circles = [];
    }
    Figures.prototype.addCircule = function (mycircle) {
        this.circles.push(mycircle);
    };
    Figures.prototype.listCircles = function () {
        for (var _i = 0, _a = this.circles; _i < _a.length; _i++) {
            var next = _a[_i];
            console.log("The ".concat(next.fillColor, " circle has area ").concat(next.radius * next.radius * 3.1415));
        }
    };
    return Figures;
}());
var myfigures = new Figures();
myfigures.addCircule({
    radius: 5, fillColor: 'Blue', lineColor: 'black', lineWeight: 2
});
myfigures.addCircule({
    radius: 6.5, fillColor: 'red', lineColor: 'darkred', lineWeight: 3
});
myfigures.listCircles();
