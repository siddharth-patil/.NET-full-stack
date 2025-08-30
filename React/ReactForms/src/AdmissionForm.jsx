import { useState } from "react";

function AdmissionForm() {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [gender, setGender] = useState("");
  const [city, setCity] = useState("");
  const [skills, setSkills] = useState("");

  const handleSkills = (event) => {
    if (event.target.checked) {
      setSkills([...skills, event.target.value]);
    } else {
      setSkills(skills.filter((item) => item !== event.target.value));
    }
  };

  const giveAlert = () => {
    alert(`Name : ${name}
Email : ${email}
Password : ${password}
Gender : ${gender}
City : ${city}
Skills : ${skills.toString()}    
        `);
  };

  return (
    <>
      <div className="container">
        <form className="form" onSubmit={giveAlert}>
          <h2>Admission Form</h2>

          <input
            onChange={(event) => setName(event.target.value)}
            value={name}
            type="text"
            name="name"
            id="name-email"
            placeholder="Enter Your Name"
          />
          <br />
          <input
            onChange={(event) => setEmail(event.target.value)}
            value={email}
            type="text"
            name="email"
            id="name-email"
            placeholder="Enter Your Email"
          />
          <br />
          <input
            onChange={(event) => setPassword(event.target.value)}
            value={password}
            type="password"
            name="password"
            id="name-email"
            placeholder="Enter Password"
          />
          <br /><br />

          <label>Select Gender :</label><br />
          <input
            onChange={(event) => setGender(event.target.value)}
            // checked={gender === "male"}
            value="Male"
            type="radio"
            name="gender"
            id="gender"
          />
          <label htmlFor="male">Male</label>
          <br />
          <input
            onChange={(event) => setGender(event.target.value)}
            // checked={gender === "female"}
            value="Female"
            type="radio"
            name="gender"
            id="gender"
          />
          <label htmlFor="female">Female</label>

          <br /><br />

          <label htmlFor="city">
            <label>Select City : </label><br />
          </label>
          <select
            onChange={(event) => setCity(event.target.value)}
            name="city"
            id="city"
          >
            <option value="">Select City</option>
            <option value="pune">Pune</option>
            <option value="satara">Satara</option>
            <option value="sangli">Sangli</option>
          </select>
          <br /><br />

          <label>Select Skills :</label><br />
          <input
            onChange={handleSkills}
            type="checkbox"
            name="skills"
            id=""
            value=".net core"
          />
          <label htmlFor="">.NET Core</label>
          <br />
          <input
            onChange={handleSkills}
            type="checkbox"
            name="skills"
            id=""
            value="sql server"
          />
          <label htmlFor="">SQL Server</label>
          <br />
          <input
            onChange={handleSkills}
            type="checkbox"
            name="skills"
            id=""
            value="angular"
          />
          <label htmlFor="">Angular</label>
          <br />
          <input
            onChange={handleSkills}
            type="checkbox"
            name="skills"
            id=""
            value="react"
          />
          <label htmlFor="">React</label>

          <br />
          <br />
          <button onSubmit={giveAlert}>Submit</button>
        </form>
      </div>
      <hr />
      <h2>Live Preview</h2>
      <div className="show-data">
        <h4>Name : {name}</h4>
        <h4>Email : {email}</h4>
        <h4>Password : {password}</h4>
        <h4>Gender: {gender}</h4>
        <h4>City : {city}</h4>
        <h4>Skills : {skills.toString()}</h4>
      </div>
    </>
  );
}

export default AdmissionForm;
