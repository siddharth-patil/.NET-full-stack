import React from "react";

class Hi extends React.Component{
    render(){
        return <h1>Hi all this is {this.props.name} from {this.props.company}!!!!!</h1>
    }
}

export default Hi;