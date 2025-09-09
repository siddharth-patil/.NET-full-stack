/* eslint-disable no-unused-vars */
import React from "react";

class User extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      // count : 0,
      userInfo: { name: "sid", location: "pun", bio: "bio", company: "tata", avatar_url:'#' },
    };
  }

  async componentDidMount() {
    const data = await fetch("https://api.github.com/users/siddharth-patil");
    const json = await data.json();
    // console.log(json);

    this.setState({
        userInfo:json
    });
  }

  render() {
    // const { name, location, contact } = this.props;
    // const { count } = this.state;

    const {name, location, company, bio, avatar_url} = this.state.userInfo;

    return (
      <div className="user-card">
        {/* <h1>Count : {count}</h1>
        <button
          onClick={() => {
            this.setState({
              count: this.state.count + 1,
            });
            // this.state.count = this.state.count + 1;
            console.log(this.state.count);
          }}
        >
          Increase Count
        </button> */}
        <img src={avatar_url} alt="" />
        <h2>Name : {name}</h2>
        <h2>Location : {location}</h2>
        <h2>Contact : siddharth-patil @{company}</h2>
        <h2>Bio : {bio}</h2>
      </div>
    );
  }
}

export default User;
