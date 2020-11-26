const delay = (time) => {
    return new Promise((resolve, reject) => {
        setTimeout(
            () => {
                console.log("Time is out!")

                resolve()
            },
            time
        )
    })
}

const promise = new Promise(resolve => {
    resolve([1, 2, 3, 4])
})

async function asyncExample() {
    await delay(2000)

    promise.then((val) => {
        console.log(val)
    }).catch((reason) => {
        console.log(reason)
    })
}

// asyncExample()

function sum(... array) {
    return new Promise((resolve, reject) => {
        var sum = 0

        for (var i = 0; i < array.length; i++) {
            sum += parseInt(array[i])
        }

        resolve(sum)
    })
}

async function count() {
    const digit = await sum(1, 2, 3)

    console.log("Result sum: " + digit)
}

count()

function multiple(... digits) {
    return new Promise((resolve, reject) => {
        var multi = digits[0]

        for (var i = 1; i < digits.length; i++)
            multi *= digits[i]

        resolve(multi)
    })
}

multiple(1, 2, 3, 4).then((val) => {
   console.log("Result multiple: " + val) 
})

const valera = document.getElementById("h1_valera")

valera.textContent = 'Валера го КС'