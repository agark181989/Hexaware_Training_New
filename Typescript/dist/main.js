"use strict";
// import {sum, sub, mul} from './file1';
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
    result["default"] = mod;
    return result;
};
Object.defineProperty(exports, "__esModule", { value: true });
// let a = 4, b= 5;
// let total = sum(a, b);
// console.log(total);
// let diff = sub(a, b);
// console.log(diff);
// let multiply = mul(a, b);
// console.log(multiply);
var calculator = __importStar(require("./file1"));
var a = 4, b = 5;
var total = calculator.sum(a, b);
console.log(total);
var diff = calculator.sub(a, b);
console.log(diff);
var multiply = calculator.mul(a, b);
console.log(multiply);
//# sourceMappingURL=main.js.map