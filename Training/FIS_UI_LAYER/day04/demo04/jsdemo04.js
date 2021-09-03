//arrays => []
//arrays => []
const color=["red","blue","green"]
//iterate : looping construct
//for, while,dowhie
console.log("For normal")
for(let i=0;i<color.length;i++){
    console.log(color[i]);
}
console.log("while normal")
let i=0;
while(i<color.length){
    console.log(color[i]);
    i++;
}
i=2;
console.log("do while normal")
do{
    console.log(color[i]);
    i++;
}while(i<color.length);
 
color.push("teal");
color.push("pink");
color.push("yellow");
 
console.log("For each")
for(let i in color){
    console.log(color[i]);   
}
console.log("before "+color.length)
console.log(color.pop());
console.log("after "+color.length)
console.log(color)
 