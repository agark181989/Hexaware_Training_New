"use strict";
var Employee = /** @class */ (function () {
    function Employee() {
        this.name = "";
        this.age = 0;
        this.dateOfJoin = new Date();
        this.salary = 0;
        this.isMarried = false;
    }
    return Employee;
}());
var emp = new Employee();
emp.name = "Rohit Agarwal";
emp.age = 25;
emp.dateOfJoin = new Date(2019, 10, 10);
emp.salary = 10000;
emp.isMarried = false;
console.log(JSON.stringify(emp));
//# sourceMappingURL=index.js.map