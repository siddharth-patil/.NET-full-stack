// import { useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
import "./App.css";
import Input from "./Input";
import MyForm from "./MyForm";
import Skills from "./Skills";
import AdmissionForm from "./AdmissionForm";
import DemoUseEffect from "./DemoUseEffect";
import Useeffect2 from "./Useeffect2";
// import Child from "./Child";
import UncontrolledInput from "./UncontrolledInput";
import Button from "react-bootstrap/Button";
import Alert from "react-bootstrap/Alert";
import Container from "react-bootstrap/Container";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import NavDropdown from "react-bootstrap/NavDropdown";
import useToggle from "./useToggle";

// import React, { createContext, useContext } from "react";

// const ThemeContext = createContext("light");

function App() {
  // const [count, setCount] = useState(0)
  // const user = { name: "Siddharth", role: "Developer" };

  const [value, toggleValue] = useToggle(true);

  console.log("val==", value);

  return (
    <div>
      <button onClick={toggleValue}>Toggle Heading</button>
      <button onClick={() => toggleValue(false)}>Hide Heading</button>
      <button onClick={() => toggleValue(true)}>Show Heading</button>
      {
        value?<h1>Custom Hooks in ReactJS</h1>:null
      }
    </div>
  );
}

  // return (
  //   <>

  //     {/* <Navbar expand="lg" className="bg-body-tertiary">
  //       <Container>
  //         <Navbar.Brand href="#home">React-Bootstrap</Navbar.Brand>
  //         <Navbar.Toggle aria-controls="basic-navbar-nav" />
  //         <Navbar.Collapse id="basic-navbar-nav">
  //           <Nav className="me-auto">
  //             <Nav.Link href="#home">Home</Nav.Link>
  //             <Nav.Link href="#link">Link</Nav.Link>
  //             <NavDropdown title="Dropdown" id="basic-nav-dropdown">
  //               <NavDropdown.Item href="#action/3.1">Action</NavDropdown.Item>
  //               <NavDropdown.Item href="#action/3.2">
  //                 Another action
  //               </NavDropdown.Item>
  //               <NavDropdown.Item href="#action/3.3">
  //                 Something
  //               </NavDropdown.Item>
  //               <NavDropdown.Divider />
  //               <NavDropdown.Item href="#action/3.4">
  //                 Separated link
  //               </NavDropdown.Item>
  //             </NavDropdown>
  //           </Nav>
  //         </Navbar.Collapse>
  //       </Container>
  //     </Navbar>

  //     <h1>Add Bootstrap in React</h1>

  //     <Alert variant="success">Hello....</Alert>

  //     <Alert variant="success">Hellooooooooo.....</Alert>

  //     <Button variant="danger">OK- react-bootstrap</Button>
  //     <Button variant="success">OK- react-bootstrap</Button>
  //     <Button variant="warning">OK- react-bootstrap</Button> */}

  //     {/* <button>OK- normal button</button> */}

  //     {/* <Input></Input> */}
  //     {/* <MyForm></MyForm> */}
  //     {/* <Skills></Skills> */}
  //     {/* <AdmissionForm></AdmissionForm> */}
  //     {/* <DemoUseEffect/> */}
  //     {/* <Useeffect2/> */}

  //     {/* Case1 : No provider --> default value 'Guest' */}
  //     {/* <Child /> */}

  //     {/* Case2 : with provider -->  */}
  //     {/* <UserContext.Provider value="ReactJS" >
  //       <Child/>
  //     </UserContext.Provider> */}

  //     {/* <UserContext.Provider value={user}>
  //       <div>
  //         <h1>App Component</h1>
  //         <Child />
  //       </div>
  //     </UserContext.Provider> */}

  //     {/* <ThemeContext.Provider value="dark">
  //       <div>
  //         <h1>App Component</h1>
  //         <Toolbar />
  //       </div>
  //     </ThemeContext.Provider> */}

  //     {/* <UncontrolledInput/> */}
  //   </>
  // );
// }

// function Toolbar() {
//   return (
//     <div>
//       <h2>Toolbar</h2>
//       <ThemedButton />
//     </div>
//   );
// }

// function ThemedButton() {
//   const theme = useContext(ThemeContext); // consume context
//   return <button>Current Theme: {theme}</button>;
// }

export default App;
