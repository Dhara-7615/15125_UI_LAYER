let counter=0;
const result=document.getElementById("result");
function onClick(event){
    const id=event.target.id;
    switch(id){
        case "b1":
                counter=counter-1;                
            break;
        case "b2":
                counter=counter+1;
            break;
        default:
            break;
    }
    result.innerHTML=counter;
}