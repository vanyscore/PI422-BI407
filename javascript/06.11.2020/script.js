function setStyle(obj) {
    obj.style.color = 'yellow'
    obj.style.backgroundColor = 'red'
    obj.style.textAlign = 'center'
    obj.style.padding = '3rem'
}

let h1 = document.getElementById("h1")
let h2 = document.getElementById("h2")
let h3 = document.getElementById('h3')

h1.onclick = () => {
    console.log('click()')

    if (h1.style.color === 'yellow') {
        h1.style.color = 'white'
    } else {
        h1.style.color = 'yellow'
    }
}

setStyle(h1)
setStyle(h2)

h2.addEventListener('dblclick', () => {
    console.log('click()')

    if (h2.style.color === 'yellow') {
        h2.style.color = 'white'
    } else {
        h2.style.color = 'yellow'
    }
})

const link = document.getElementById('a1')

console.log(link)

var countClick = 0

link.addEventListener('click', (event) => {
    countClick++

    if (countClick == 5) {

    }

    event.preventDefault()

    console.log(event)
    console.log(countClick)
    console.log(event.target.getAttribute('href'))

    if (countClick > 5) {
        var url = event.target.getAttribute('href')

        window.open(url)
    }
})