function getName(name) {
    console.log(name)
}

getName("Иван")

const fun = function (name) {
    console.log("Name: " + name)
}

fun("Вася")

console.log(typeof fun)
console.log(fun)

var counter = 0

// setInterval(function() {
//     console.log(`Counter ${counter}`)

//     counter++
// }, 1000)

const arrow = (name) => {
    console.log(name)
}
arrow("Petya")

const arrow_2 = name => console.log(name)

arrow_2("Petr")

const fun_pow = (x, n) => {
    return x**n
}

console.log(fun_pow(2, 7))

// Параметры по умолчанию

const sum = (a, b = 0) => a + b

console.log(sum(2, 2))
console.log(sum(2))

function sumAll(... all) {
    console.log(all)
    
    var sum = 0

    for (let number of all) {
        sum += number
    }

    console.log("Result sum: " + sum)
}

sumAll(2, 2, 2, 2,)

function createUser(userName) {
    return function (lastName) {
        console.log(`UserName: ${userName}, LastName: ${lastName}`)
    }
}


createUser("Че?")("Кого")

const cars = ['Жига', 'Четырка', 'Волга', 'Девяностодевятая']

cars.push('Шаха')

console.log(cars)

const firstCar = cars.shift()

console.log("Removed car: " + firstCar)
console.log(cars)

var text = 'We are learning javascript'

function reverseString(str) {
    var newText = ''

    for (var i = str.length - 1; i >= 0; i--) {
        newText += str[i]
    }

    return newText
}

console.log(text)
console.log(text.split('').reverse().join(''))
console.log(reverseString(text))

console.log(cars.find(function (value, index, obj) {
    if (value == 'Шаха')
        console.log(`${value} on index: ${index}`)
}))

var peoplesArray = [
    { name: "Ivan", many: 400 },
    { name: "Vasya", many: 500 },
    { name: "Petya", many: 600 },
    { name: "Leha", many: 700 },
]

console.log(peoplesArray.findIndex(function (person) {
    return person.many == 700
}))

console.log(
    peoplesArray.filter(
        person => person.many > 400
    ).reduce()
)