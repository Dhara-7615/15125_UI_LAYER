function addHobby(){
    alert("Button click");
    //1.1 read input:text hobby 
    const hobby=document.getElementById("hobby");
    //   1.2 access the ul hobbies
    const hobbies=document.getElementById("hobbies");
    //2 create li element
    const li=document.createElement("li");
    li.innerHTML=hobby.value;
    //3 append it to the hobbies ul
    hobbies.appendChild(li)
}
