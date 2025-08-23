import React from "react";

class Car extends React.Component{
    constructor(){
        super();
        this.state = {
            brand:'BMW',
            model:'X3',
            color:'white',
            year:'2025'
        }
    }

    render(){
        return(
            <div>
                <h4>My {this.state.brand} {this.state.model}</h4>
                <p>It is a {this.state.color} in color<br />
                     <br />
                    and launched in {this.state.year}
                </p>

            </div>
        )
    }
}

export default Car;