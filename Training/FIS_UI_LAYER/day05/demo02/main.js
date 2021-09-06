let counter=0;
const result=document.getElementById("result");

function updateResult(){
    result.innerHTML=counter;
}

function increment(){
    counter=counter+1;
    updateResult();
}

function decrement(){
    counter=counter-1;
    updateResult();
}