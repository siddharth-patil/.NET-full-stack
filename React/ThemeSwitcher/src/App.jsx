import { useState } from "react";
import ThemeContext from "./ThemeContext";
import Toolbar from "./Toolbar";

function App() {
  const [theme, setTheme] = useState("light");

  const toggleTheme = () => {
    setTheme((prev) => (prev === "light" ? "dark" : "light"));
  };

  return (
    <ThemeContext.Provider value={theme}>
      <div style={{
        backgroundColor: theme === "dark" ? "#333" : "#fff",
        color: theme === "dark" ? "#fff" : "#000",
        minHeight: "100vh",
        padding: "20px"
      }}>
        <h1>React useContext + useRef Example</h1>
        <button onClick={toggleTheme}>
          Switch to {theme === "light" ? "Dark" : "Light"} Mode
        </button>
        <Toolbar />
      </div>
    </ThemeContext.Provider>
  );
}

export default App;
