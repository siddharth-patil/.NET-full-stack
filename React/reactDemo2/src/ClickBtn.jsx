import React from "react";

class ClickBtn extends React.Component{

    handleClick(){
        alert('you clicked the button');
    }
    //Passing argument to the event handler
    shoot(msg){
        alert(msg);
    }

    render(){
        return(
            <>
                <button onClick={this.handleClick}>Click Here...</button>  <br />

                <button onClick={this.shoot.bind(this,"Goal!!")}>Take the shot!!</button> <br />

                <button onClick={(e)=>this.shoot('Goal',e)}>Take the shot again!!</button> <br /><br />

                <button onClick={() => alert('Hellooo!')}>Say Hello</button>
            </>
        )
    }
}

export default ClickBtn;