import React from "react";
import User from "./User";

class About extends React.Component{

    constructor(props){
        super(props);
    }

    componentDidMount(){
        
    }

    render(){

         return(
        <div className="about-page">
            <h1>About</h1>
            {/* <h2>This is About us page.</h2> */}
            <User name='Siddharth Patil' location='Ravet' contact='sid@gmail.com'/>
        </div>
    )

    }
}

// const About = ()=>{

//     return(
//         <div className="about-page">
//             <h1>About</h1>
//             {/* <h2>This is About us page.</h2> */}
//             <User name='Siddharth Patil' location='Ravet' contact='sid@gmail.com'/>
//         </div>
//     )
// }

export default About;