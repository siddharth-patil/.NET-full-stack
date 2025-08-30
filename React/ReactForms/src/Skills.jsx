import { useState } from "react";

function Skills() {
  const [skills, setSkills] = useState([]);
  const [gender, setGender] = useState('');
  const [city, setCity] = useState('');

  const handleSkills = (event) => {
    console.log(event.target.value, event.target.checked);

    if (event.target.checked) {
      setSkills([...skills, event.target.value]);
    } else {
      setSkills(skills.filter((item) => item !== event.target.value));
    }
  };

  const handleGneder = (event) => {
    // console.log(event.target.value);
    setGender(event.target.value);
  };

  return (
    <div>
      <h3>Select Your skills</h3>

      <input
        onChange={handleSkills}
        type="checkbox"
        name=""
        id="php"
        value="PHP"
      />
      <label htmlFor="php">PHP</label>
      <br />

      <input
        onChange={handleSkills}
        type="checkbox"
        name=""
        id="javascript"
        value="JavaScript"
      />
      <label htmlFor="javascript">JavaScript</label>
      <br />

      <input
        onChange={handleSkills}
        type="checkbox"
        name=""
        id="react"
        value="React"
      />
      <label htmlFor="react">React</label>
      <br />
      <h2>{skills.toString()}</h2>
      <br /> <br />

      <input onChange={handleGneder} checked={gender === "male"} value="Male" type="radio" name="gender" id="male" />
      <label htmlFor="male">Male</label>
      <br />
      <input onChange={handleGneder} checked={gender === "female"} value="Female" type="radio" name="gender" id="female" />
      <label htmlFor="female">Female</label>
      <br />
      <h2>{gender}</h2>
      <br /><br />

      <select onChange={(event) => setCity(event.target.value)} name="city" id="city">
        <option value="">Select City</option>
        <option value="pune">Pune</option>
        <option value="satara">Satara</option>
        <option value="sangli">Sangli</option>
      </select>
      <br />
      <h2>{city}</h2>
    </div>
  );
}

export default Skills;
