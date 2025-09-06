import React from "react";

class User extends React.Component{

    constructor(props){
        super(props);

        this.state = {
            count : 0,
        }
    }

    componentDidMount(){
        
    }


    render(){
        const {name, location, contact} = this.props;
        const {count} = this.state;
        return(
            <div className="user-card">
                <h1>Count : {count}</h1>
                <button onClick={()=>{
                    this.setState({
                        count : this.state.count + 1,
                    })
                    // this.state.count = this.state.count + 1;
                    console.log(this.state.count);
                    
                }}>Increase Count</button>
                <h2>Name : {name}</h2>
                <h2>Location : {location}</h2>
                <h2>Contact : {contact}</h2>
            </div>
        )
    }

}

export default User;