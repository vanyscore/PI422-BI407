// const persona = 
//  {
//      firstName:'Valerii',
//      LastName:'Kolunov',
//      year:2000,
//      language:['Ru','Eng'],
//      hasWife:false,
//      Work:function()
//      {
//          console.log('In Search');
//      }
//  }

//  console.log(persona);
//  console.log(persona.firstName);
//  persona.Work();
//  console.log(persona['LastName']);
//  const key = 'language';
//  console.log(persona[key]);
// persona.isProgrammer = true;
// console.log(persona);

// // ============

// const num_1 = 42
// const num_2 = 42.42
// const num_3 = 10e3

// console.log(num_1)
// console.log(num_2)
// console.log(num_3)

// console.log(Number.NaN)
// console.log(typeof Nan)

// console.log(5 / undefined)

// const w = 5 / undefined

// console.log(Number.isNaN(w))
// console.log(Number.isNaN(55))

// const stringInt = '33'
// const stringFloat = '33.33'

// console.log(stringInt + 2)

// console.log(Number.parseInt(stringInt))
// console.log((0.2 + 0.4).toFixed(4))

// console.log(Math.PI)
// console.log(Math.E)
// console.log(Math.sqrt(4))
// console.log(Math.pow(5, 2))

// console.log(Math.abs(-11))
// console.log(Math.min(2, 3, 32,1, 2))

// console.log(Math.floor(4.2))
// console.log(Math.ceil(4.4))
// console.log(Math.round(4.4))

// console.log(myRandom(2, 16))

// function myRandom(min, max) {
//     return Math.round(min + ((max - min) * Math.random()))  
// }

const name = "Vany"
const age = 20

const output = "Имя " + name + " Возраст " + age

console.log(output)

const output_2 = `Меня зовут: ${name}, Мой возраст: ${getAge()}`

console.log(output_2)

function getAge() {
    return age
}

function logUser(userName, userAge) {
    return `${userName}, ${userAge}`
}

let info = logUser(name, age)

console.log(info)