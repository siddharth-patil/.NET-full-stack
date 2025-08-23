import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
// import './App.css'
import Header from './Header.jsx'
import Welcome from './Welcome.jsx'
import Hi from './Hi.jsx'
import Car from './Car.jsx'
import ClickBtn from './ClickBtn.jsx'
import ClickBtnFunc from './ClickBtnFunc.jsx'
import EventDemo from './EventDemo.jsx'
import Todo from './Todo.jsx'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      {/* <div>
        <Header></Header>
        <Welcome name='Siddharth' version='2.0'></Welcome>
        <Hi name='Siddharth' company='Microsoft'></Hi>

        <Car></Car>
      </div> */}
      <div>
       {/* <ClickBtn></ClickBtn> <br />
       <ClickBtnFunc></ClickBtnFunc> */}

        {/* <EventDemo></EventDemo> */}

        <Todo></Todo>

      </div>
    </>
  )
}

export default App
