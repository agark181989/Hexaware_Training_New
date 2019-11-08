class Employee{
    name:string = "";
    age:number = 0;
    dateOfJoin:Date = new Date();
    salary:number = 0;
    isMarried:boolean = false;
}

var emp:Employee = new Employee();
emp.name = "Rohit Agarwal";
emp.age = 25;
emp.dateOfJoin = new Date(2019, 10,10);
emp.salary = 10000;
emp.isMarried= false;

console.log(JSON.stringify(emp));