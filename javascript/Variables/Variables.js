let myName = 'Sally';
//var myName = 'Joe'; - throws error
//let myName = 'Joe'; - throws error 
let myAge = 43;
let myHobbies = ['jogging','movies','books'];
let hasCar = true;
let quantityOfKids = NaN;
let pet = 
{
  type:'Dog',
  breed: 'Dalmatian',
  name: 'Spot'
}

var a;
var b;

console.log('My name is ' + myName + ' and the datatype in JS is' + typeof myName);
console.log('My age is ' + myAge + ' and the datatype in JS is ' + typeof myAge);
console.log('My hobbies are ' + myHobbies + ' and the datatype in JS is', typeof myHobbies);
console.log('I own at least one car ' + hasCar + ' and the datatype in JS is ', typeof hasCar);
console.log('My pet is a ' + pet.type + ' and the datatype in JS is ', typeof pet);
console.log('I have this many kids ' + quantityOfKids + ' and the datatype in JS is ', typeof quantityOfKids);

//output of variables being decalred with var
console.log('The value of a is ' + a);

var input;
if(input === undefined)
{
  console.log('The variable input is undefined');
}

var n=null;
console.log(n * 32); //Will log 0 to the console

let fish = ['Lion',,'Angel'];