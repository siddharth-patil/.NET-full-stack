import React from "react";

class EventDemo extends React.Component{

    constructor(){
        super();
        this.state = {msg:'Hello'}
    }

    handleClick(){
        this.setState({msg:'Welcome to the React World ! But do not forget Angular'})
    }

    render(){
        return(
            <div>
                <h2>Message: </h2> <p>{this.state.msg}</p>

                <button onClick={this.handleClick.bind(this)}>EventDemo - Click Here!</button>
            </div>
        )
    }

}

export default EventDemo;