console.log("hello")

const person = {
    name: "Ivan",
    age: 31,
    isProgrammer: true,
    language: ['En', 'Ru', 'Cz'],

    greet() {
        console.log(`greet from ${this.name}`)
    },

    info() {
        console.log(this)
    }
}

console.log(person.name)
console.log(person['age'])
console.log(person['language'][0])

person.language.push('Uk')

delete(person.language[3])

console.log(person.language)
person.greet()

// Деструктуризация

// const name = person.name
// const age = person.age
// const language = person.language

// const { name:newName } = person

// // console.log(`${name}, ${age}, ${language}`)

// console.log(newName)

// for (let property in person) {
//     console.log(`prop: ${property}, value ${person[property]}`)
// }

person.info()

const logger = {
    keys() {
        console.log("Properties", Object.keys(this))
    },
    keysAndValues() {
        Object.keys(this).forEach(function (key) {
            console.log(`${key}: ${this[key]}`)
        }.bind(this))
    },
    whichParam(top = false, between = false, bottom = false) {
        if (top) {
            console.log('start')
        }
        Object.keys(this).forEach((key, index, array) => {
            console.log(key + " value: " + this[key])

            if (between && index < array.length - 1) {
                console.log('----------------')
            }
        })
        if (bottom) {
            console.log('end')
        }
    }
}

logger.keys(person)

const myBind = logger.keys.bind(person)

console.log('-----------------')

logger.keys.call(person)
logger.keysAndValues()

logger.whichParam(true, true, true)

logger.whichParam.apply(person, [true, true, true])