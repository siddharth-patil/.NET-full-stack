import { useContext } from "react";
import ThemeContext from "./ThemeContext";

function Button() {
  const theme = useContext(ThemeContext); // consume context

  return (
    <button
      style={{
        background: theme === "dark" ? "white" : "black",
        color: theme === "dark" ? "black" : "white",
        border: "2px solid",
        margin: "10px",
        padding: "10px"
      }}
    >
      Themed Button
    </button>
  );
}

export default Button;
