// import {sum, sub, mul} from './file1';

// let a = 4, b= 5;

// let total = sum(a, b);
// console.log(total);

// let diff = sub(a, b);
// console.log(diff);

// let multiply = mul(a, b);
// console.log(multiply);

import * as calculator from './file1';

let a = 4, b= 5;

let total = calculator.sum(a, b);
console.log(total);

let diff = calculator.sub(a, b);
console.log(diff);

let multiply = calculator.mul(a, b);
console.log(multiply);