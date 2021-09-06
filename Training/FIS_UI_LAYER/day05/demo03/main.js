const app=(
    function(){
        console.log("app coding started ");
        let counter=0;
        const result=document.getElementById("result");
        function updateResult(){
            result.innerHTML=counter;
        }
        function _increment(){
            counter=counter+1;
            updateResult();
        }
        function _decrement(){
            counter=counter-1;
            updateResult();
        }
        console.log("app coding completed... ");
        return {
            increment:function(){
                _increment();
            },
            decrement:function(){
                _decrement();
            }
        };
    }
)();
// app();