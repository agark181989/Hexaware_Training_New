// import {Employee} from './models/employee';
// import {EmployeeService} from './services/employee.service';

// import {Product} from './models/product';
// import {ProductService} from './services/product.service';

// import {User} from './models/user';
// import {UserService} from './services/user.service';

import {Product, User, Employee} from './models'
import {ProductService, UserService, EmployeeService} from './services'


let empsrv:EmployeeService = new EmployeeService();
let employee:Employee[] = empsrv.getEmployees();

let prodsrv:ProductService = new ProductService();
let product:Product[] = prodsrv.getProduct();

let userserv:UserService = new UserService();
let user:User[] = userserv.getUsers();
