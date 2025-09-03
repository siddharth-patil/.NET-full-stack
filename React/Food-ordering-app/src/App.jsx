import './App.css'
import Header from './components/Header'
import Body from './components/Body'
import { Outlet } from 'react-router-dom'

function App() {
  // console.log(<Body/>)
  return (
    <>
      <div className="app">
        <Header></Header>
        {/* <Body></Body> */}
        <Outlet/>
        {/* {console.log(<Body/>)} */}
        
      </div>
    </>
  )
}

export default App
