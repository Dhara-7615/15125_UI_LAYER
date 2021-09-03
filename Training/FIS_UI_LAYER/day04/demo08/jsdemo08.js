function doSomething(msg,funRef){
    console.log(msg);
    funRef();
}
 
doSomething("Providing anonymous function",function(){
    console.log("Called only once with dosomething")
});