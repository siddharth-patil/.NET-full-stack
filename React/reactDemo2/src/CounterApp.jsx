import React, { useState } from "react";

function CounterApp() {
  const [count, setCount] = useState(0);
  const [countDecrement, setCountDecrement] = useState(0);

  return (
    <>
      <div>
        <p>You clicked {count} times.</p>
        <button onClick={() => setCount(count + 1)}>Click Here (Increment)</button>
      </div>

      <div>
        <p>You clicked {countDecrement} times.</p>
        <button onClick={() => setCountDecrement(countDecrement - 1)}>Click Here (Decrement)</button>
      </div>
    </>
  );
}

export default CounterApp;
