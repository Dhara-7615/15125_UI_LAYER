function myFunction(){
    console.log("myfunction called ");
}
function doSomething(msg,fun_ref){
    console.log("do Soemthing :"+msg);
    fun_ref();
}
 
doSomething("Calling Do something to call myfunction",myFunction)