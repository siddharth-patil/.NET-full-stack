function ClickBtnFunc(){
    function sayHello(){
        alert('Hello!!');
    }

    return(
        <button onClick={sayHello}>Click Me!</button>
    )
}

export default ClickBtnFunc;