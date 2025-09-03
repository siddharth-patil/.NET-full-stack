import { useEffect, useState } from "react";

function DemoUseEffect() {
  const [counter, setCounter] = useState(0);
  const [data, setData] = useState(0);

  useEffect(()=>{
    // callOnce();
    counterFunction();
  },[counter]);

  useEffect(()=>{
    dataFunction();
  },[data])
  
  useEffect(()=>{
    callOnce();
  },[data,counter])

  function callOnce() {
    console.log("callOnce function called");
  }

  function counterFunction(){
    console.log('CounterFunction', counter);
  }

   function dataFunction(){
    console.log('DataFunction', counter);
  }

//   callOnce();
  return (
    <div>
      <h1>useEffect Hook</h1>
      <button onClick={() => setCounter(counter + 1)}>Count {counter}</button>
      <br /> <br />
      <button onClick={() => setData(data + 1)}>Data {data}</button>
    </div>
  );
}

export default DemoUseEffect;
