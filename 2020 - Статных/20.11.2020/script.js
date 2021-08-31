// const animal = {
    // name: "Вася",
    // age: 3,
    // type: "Кот",
    // isHome: true
// }

// console.log(animal)

class Animal {

    static typeAnimal = "type: Animal"

    constructor(options) {
        this.name = options.name,
        this.age = options.age,
        this.type = options.type,
        this.isHome = options.isHome
    }

    voice() {
        console.log("Армяу!")
    }
}

const myAnimal = new Animal({
    name: "Вася",
    age: 3,
    type: "Кот",
    isHome: true
})

console.log(myAnimal)

myAnimal.voice()

console.log(Animal.typeAnimal)

class Cat extends Animal {

    static typeAnimal = 'Cat'

    constructor(options) {      
        options.isHome = true
        options.type = "Кот"

        super(options)

        this.color = options.color
        this.sound = "Арррмяу!"
    }

    get ageInfo() {
        return this.age * 5
    }
    set ageInfo(newAge) {
        this.age = newAge
    }

    voice() {
        super.voice()

        console.log("I am " + this.name + " " + this.sound)
    }

}

const myCat = new Cat({
    name: "Барсик",
    age: 5,
    color: "#000000"
})

console.log(myCat)

myCat.ageInfo = 10

console.log(myCat.ageInfo)

myCat.voice()

console.log(Cat.typeAnimal)

//---------------------------------

class Component {

    constructor(options) {
        this.$element = document.querySelector(options.selector)
    }

    hide() {
        this.$element.style.display = "none"
    }

    show() {
        this.$element.style.display = "block"
    }

}

class Box extends Component {

    constructor(options) {
        super(options)

        this.$element.style.width = this.$element.style.height = options.size + "px"
        this.$element.style.background = options.color
    }

}

const box_1 = new Box({
    selector: "#box_1",
    size: 100,
    color: "red"
})

box_1.hide()
box_1.show()

const box_2 = new Box({
    selector: "#box_2",
    size: 150,
    color: "blue"
})

class Circle extends Box {

    constructor(options) {
        super(options)

        this.$element.style.borderRadius = "50%"
    }

}

const circle = new Circle({
    selector: "#box_3",
    size: 200,
    color: "yellow"
})

// -----------------------

async function delay(milis) {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve()
        }, milis)
    })
}

async function toDo() {
    console.log("Start")

    const response = await fetch("https://jsonplaceholder.typicode.com/todos/1")

    await delay(1000)

    console.log(response.status)
    console.log(await response.json())

    console.log("finish")
}

toDo()