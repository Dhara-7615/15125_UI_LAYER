alert("hello");
var a = document.querySelector('#s1');
a.onclick = function(){
    alert("this is inline css");
};
var b = document.querySelector('#s2');
b.onclick = function(){
    alert("this is internal css");
};
var c = document.querySelector('#s3');
c.onclick = function(){
    alert("this is external css");
};