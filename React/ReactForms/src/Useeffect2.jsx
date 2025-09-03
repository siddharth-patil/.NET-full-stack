import { useEffect } from "react";

const f1 = () => {
    console.log("callOnce function called....");
  }

function Useeffect2() {
  useEffect(f1, []); // empty dependency array = run once

  return (
    <div>
      <h1>useEffect Hook</h1>
    </div>
  );
}

export default Useeffect2;