const timeOut = setTimeout(() => 
{
    console.log('My timeOut')
}, 3000);
// clearTimeout(timeOut)

const interval = setInterval(() => 
{
    clearInterval(interval)
    console.log('My timeOut')
}, 2000);

const delay = (callBack,wait = 1000) =>
{
    setTimeout(callBack, wait)
}

delay(()=>
{
    console.log('My code')
},2000)

const delay1 = (time = 1000) =>
{
    let myPromis = new Promise((resolve,reject) =>
    {
        setTimeout(() => 
        {
            //resolve()    
           reject()
        }, time);
    })
    return myPromis
}
delay1(2500)
    .then(()=>
    {
        console.log('then promise 2500')
    })
    .catch((err)=>
    {
        console.error('Error:',err)
    })
    .finally(()=>
    {
        console.log('Finall')
    })

    const getData = ()=> new Promise(resolve => resolve([1,2,3,4,5,6,7,8]))
    getData().then((data)=> {console.log(data)})

    async function asyncExample()
    {
        try 
        {
            await delay1(3000)
            const data = await getData()
            console.log(data)
        } catch (e) 
        {
            console.log(e)
        }
    }
    asyncExample()