import { Link } from "react-router";

function Navbar() {
  return (
    <div class="navbar">
      <div>
        <Link className="link">
          <h2>Logo</h2>
        </Link>
      </div>

      <div className="nav-links">
        <ul>
            <li><Link className="link" to={"/"}>Home</Link></li>
            <li><Link className="link" to={"/about"}>About</Link></li>
            <li><Link className="link" to={"/login"}>Login</Link></li>
        </ul>
      </div>
    </div>
  );
}

export default Navbar;
