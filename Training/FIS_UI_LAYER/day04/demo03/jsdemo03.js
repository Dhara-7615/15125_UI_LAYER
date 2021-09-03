function onClick(event){
    // alert(event.target);
    const id=event.target.id;
    // alert(id+" Click!");
    // const message=document.getElementById(id).value;
    // const message=document.getElementById(id).innerText;
    const button=document.getElementById(id);
    const message=button.innerText;
    alert(message+" Clicked!");
    button.innerHTML="<strong>"+message+"</strong>";
    button.style.backgroundColor="#567488";
    button.style.color="#ffffff";
 
}