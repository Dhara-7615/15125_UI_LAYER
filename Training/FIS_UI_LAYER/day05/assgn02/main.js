alert("Hello!");
var s = document.getElementById('sugar').value;
console.log(s);
var m = document.getElementById('Milk').value;
console.log(m);
var d = document.querySelector("#display")
document.querySelector('#button').onclick = 
function makeCoffee(){
    d.innerHTML += "Making Coffee with " +s+ " and "+ m;
}

