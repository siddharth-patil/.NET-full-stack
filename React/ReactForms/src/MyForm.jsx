import React from "react";

class MyForm extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      personName: "",
      course: "",
      email: "",
      contact: "",
    };

    this.handleInputChange = this.handleInputChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleSubmit(event) {
    event.preventDefault();
    alert("Form Submitted successfully...!");
    alert(
      this.state.personName +
        "\n " +
        this.state.course +
        "\n " +
        this.state.email +
        "\n " +
        this.state.contact
    );

    const data = document.getElementById("display-data");

    data.style.display = "block";
  }

  handleInputChange(event) {
    const target = event.target;
    const name = target.name;
    const value = target.value;

    this.setState({
      [name]: value,
    });
  }

  render() {
    return (
      <>
        <form onSubmit={this.handleSubmit}>
          <h1>Enquiry Form</h1>
          <div>
            <label htmlFor="">Your Name:</label>
            <input
              type="text"
              name="personName"
              value={this.state.personName}
              onChange={this.handleInputChange}
            />{" "}
            <br />
          </div>
          <div>
            <label htmlFor="">Select Course:</label>
            <select
              name="course"
              value={this.state.course}
              onChange={this.handleInputChange}
              id=""
            >
              <option value="">select--</option>
              <option value="C#">C#</option>
              <option value="Python">Python</option>
              <option value="Javascript">Javascript</option>
            </select>{" "}
            <br />
          </div>
          <div>
            <label htmlFor="">Your Email:</label>
            <input
              type="text"
              name="email"
              value={this.state.email}
              onChange={this.handleInputChange}
            />{" "}
            <br />
          </div>
          <div>
            <label htmlFor="">Your Contact:</label>
            <input
              type="number"
              name="contact"
              value={this.state.contact}
              onChange={this.handleInputChange}
            />{" "}
            <br />
          </div>
          <input type="submit" value="Submit Enquiry" />
        </form>
        <br />
        <br />

        <fieldset id="display-data">
          <legend>Your Enquiry</legend>
          <b>Name: {this.state.personName}</b>
          <br />
          <b>Course: {this.state.course}</b>
          <br />
          <b>Email: {this.state.email}</b>
          <b>Email: {this.state.contact}</b>
        </fieldset>
      </>
    );
  }
}

export default MyForm;
