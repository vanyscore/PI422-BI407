const h1 = document.getElementById('h1');
console.log(h1)
console.dir(h1)
console.log(h1.id)
console.log(h1.textContent)

setTimeout(() => 
{
    h1.textContent = 'Я'
    h1.style.color = 'green'
    h1.style.textAlign = 'center'
    h1.style.backgroundColor = 'black'
    h1.style.padding = '2rem'
    
}, 2000);

setTimeout(() => 
{
    h2.textContent = 'Изучаю'
    h2.style.color = 'red'
    h2.style.textAlign = 'center'
    h2.style.backgroundColor = 'black'
    h2.style.padding = '2rem'
    
}, 4000);
setTimeout(() => 
{
    h3.textContent = 'JavaScript'
    h3.style.color = 'green'
    h3.style.textAlign = 'center'
    h3.style.backgroundColor = 'black'
    h3.style.padding = '2rem'
    
}, 6000);

//let h2 = document.getElementsByTagName('h2')
let h3 = document.getElementsByClassName('h3-class')[0]

/*h2 = document.querySelector('.h3-class')
h2 = document.querySelectorAll('.h3-class')
h2 = document.querySelector('#h1')*/
console.log(h1)