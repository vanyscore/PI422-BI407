// console.log("hello")

// var persona = {
    // name: 'Alexey',
    // age: 31,

    // getLanguage:() => {
    //     console.log("My language: RU")
    // }
// }

// console.log(persona)
// console.log(persona.toString())

// persona.getLanguage()

// var persona = new Object({
//     name: 'Alexey',
//     age: 31,

//     getLanguage:() => {
//         console.log("My language: RU")
//     }
// })

// console.log(persona)

// Object.prototype.sayHello = function() {
//     console.log('hello')
// }

// persona.sayHello()

// const lena = Object.create(persona)

// console.log(lena)

// lena.getLanguage()
// console.log(lena.name)

// lena.name = "Ленка"
// console.log(lena.name)

// const myName = 'My name Alexey'

// console.log(myName.length)
// console.log(myName.bold())

// const name = new String("I am Alexey")

// console.log(name)
// name.sayHello()

const persona = Object.create({
    calc:() => {
        return this.age
    }
}, {
    name: {
        value: 'Иван',
        enumerable: true,
        writable: true,
        configurable: true
    },
    birth: {
        value: 2000
    },
    age: {
        get() {
            return new Date().getFullYear() - this.birth
        },
        set() {

        },
        enumerable: true
    }
})

persona.name = 'Иван'

for (let key in persona) {
    console.log("key = ", key)
    console.log("value = ", persona[key])
}

delete persona.name

console.log(persona)
console.log(persona.calc())