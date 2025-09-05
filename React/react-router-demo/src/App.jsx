import { Link, Routes, Route } from "react-router";
import About from "./About";
import Login from "./Login";
import Home from "./Home";
import Navbar from "./Navbar";

function App() {
  return (
    <>
      {/* <Link to={"/"}>Home</Link>
      <Link to={"/about"}>About</Link>
      <Link to={"/login"}>Login</Link> */}

      <Navbar></Navbar>

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/about" element={<About />} />
        <Route path="/login" element={<Login />} />
      </Routes>
    </>
  );
}

export default App;
