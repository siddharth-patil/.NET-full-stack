import React, { Component } from 'react';
// import './ToDo.css';

class TodoNew extends Component {
  constructor(props) {
    super(props);
    this.state = {
      show: true
    };
  }

  // Show alert when button clicked
  showMessage = () => {
    alert("Seed Infotech Task Executed");
  };

  // Toggle heading visibility
  toggleName = () => {
    this.setState((prevState) => ({ //That function receives the previous state (prevState) as an argument.
      show: !prevState.show
    }));
  };

  render() {
    return (
      <div>
        {this.state.show && <h1>Seed Infotech To-Do List</h1>}

        <img
          src="https://tse4.mm.bing.net/th/id/OIP.WEmH9EnrHIWqTUNTrP34yQHaEK?pid=Api&P=0&h=180"
          alt="Seed Infotech"
          className="photo"
        />

        <ul>
          <li>Conduct Java Full-Stack Training</li>
          <li>Prepare Angular Practical Demos</li>
          <li>Organize Mock Interviews for Students</li>
          <li>Update Placement Portal with Job Openings</li>
          <li>Schedule Weekend Workshops</li>
        </ul>

        <div className="btn-group">
          <button onClick={this.showMessage}>Mark Task</button>
          <button onClick={this.toggleName}>Toggle Name</button>
        </div>
      </div>
    );
  }
}

export default TodoNew;