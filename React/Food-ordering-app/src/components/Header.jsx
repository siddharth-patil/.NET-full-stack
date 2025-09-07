import { LOGO_URL } from "../utils/restList";
import { useState } from "react";
import { Link } from "react-router-dom";
import useOnlineStatus from "../utils/useOnlineStatus";

function Header() {
  const [btnNameReact, setBtnNameReact] = useState("Login");

  const onlineStatus = useOnlineStatus();

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
            <li>Cart</li>
            <button
              className="login"
              onClick={() => {
                btnNameReact === "Login"
                  ? setBtnNameReact("Logout")
                  : setBtnNameReact("Login");
              }}
            >
              {btnNameReact}
            </button>
          </ul>
        </div>
      </div>
    </>
  );
}

export default Header;
