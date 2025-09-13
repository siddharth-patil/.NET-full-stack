import "./App.css";
import Header from "./components/Header";
import Body from "./components/Body";
import { Outlet } from "react-router-dom";
import { Route, Routes } from "react-router-dom";
import Contact from "./components/Contact";
import About from "./components/About";
import Error from "./components/Error";
import RestaurantMenu from "./components/RestaurantMenu";
import { useEffect, useState } from "react";
import UserContext from "./utils/UserContext";
import { Provider } from "react-redux";
import appStore from "./utils/appStore";

function App() {
  // console.log(<Body/>)

  const [userName, setUserName] = useState();

  useEffect(() => {
    const data = {
      name: "Siddharth Patil",
    };
    setUserName(data.name);
  }, []);

  return (
    <>
      <Provider store={appStore}> 
        <UserContext.Provider value={{ loggedInUser: userName }}>
          <div className="app">
            <Header></Header>
            <Outlet />

            {/* <Header></Header>

        <Routes>
          <Route path="/" element={<Body />}>
            <Route path="/restaurants/:resId" element={<RestaurantMenu/>} />
          </Route>
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
        </Routes> */}
          </div>
        </UserContext.Provider>
      </Provider>
    </>
  );
}

export default App;
