import { useState } from "react";

function Skills() {
  const [skills, setSkills] = useState([]);

  const handleSkills = (event) => {

    console.log(event.target.value, event.target.checked);
    

    if (event.target.checked) {
      setSkills([...skills, event.target.value]);
    } else {
      setSkills(skills.filter((item) => item !== event.target.value));
    }
  };

  const handleGneder = (event)=>{
    console.log(event.target.value);
  }

  return (
    <div>
      <h3>Select Your skills</h3>

      <input onChange={handleSkills} type="checkbox" name="" id="php" value="PHP" />
      <label htmlFor="php">PHP</label>
      <br />

      <input onChange={handleSkills} type="checkbox" name="" id="javascript" value="JavaScript" />
      <label htmlFor="javascript">JavaScript</label>
      <br />

      <input onChange={handleSkills} type="checkbox" name="" id="react" value="React" />
      <label htmlFor="react">React</label>
        <br /><br />

        <input onClick={handleGneder} type="radio" name="gender" id="male" />
        <label htmlFor="male">Male</label>
        <br />
        <input onClick={handleGneder}  type="radio" name="gender" id="female" />
        <label htmlFor="female">Female</label>

      <br /><br />

      <h2>{skills.toString()}</h2>
    </div>
  );
}

export default Skills;
