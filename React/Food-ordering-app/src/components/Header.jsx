/* eslint-disable no-unused-vars */
import { LOGO_URL } from "../utils/restList";
import { useContext, useState } from "react";
import { Link } from "react-router-dom";
import useOnlineStatus from "../utils/useOnlineStatus";
import UserContext from "../utils/UserContext";
import { useSelector } from "react-redux";

function Header() {
  const [btnNameReact, setBtnNameReact] = useState("Login");

  const onlineStatus = useOnlineStatus();

  // const data = useContext(UserContext);
  const {loggedInUser} = useContext(UserContext);

  //subscribing to the store using selector
  const cartItems = useSelector((store)=> store.cart.items);

  return (
    <>
      <div className="header">
        <div className="logo-container">
          <img className="logo" src={LOGO_URL} alt="logo" />
          <h2>Food App</h2>
        </div>
        <div className="nav-items">
          <ul>
            <li>
              {onlineStatus === false ? '🔴' : '🟢'}
            </li>
            <li>
              <Link className="link" to="/">Home</Link>
            </li>
            <li>
              <Link className="link" to="/about">About</Link>
            </li>
            <li>
              <Link className="link" to="/contact">Contact</Link>
            </li>
            <li>
              {/* using lazy loading for grocey (routing) */}
              <Link className="link" to="/grocery">Grocery</Link>
            </li>
            <li className="fw-bold">
              <Link className="link" to="/cart">  Cart - ({cartItems.length} items)</Link>
            </li>
            <button
              className="login mx-2"
              onClick={() => {
                btnNameReact === "Login"
                  ? setBtnNameReact("Logout")
                  : setBtnNameReact("Login");
              }}
            >
              {btnNameReact}
            </button>

            <li className="px-2">{loggedInUser}</li>
          </ul>
        </div>
      </div>
    </>
  );
}

export default Header;
