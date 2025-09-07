import { useRef, useEffect } from "react";

function LoginForm() {
  const inputRef = useRef(null);

  useEffect(() => {
    inputRef.current.focus(); // autofocus on mount
  }, []);

  return (
    <div style={{ marginTop: "20px" }}>
      <h3>Login</h3>
      <input
        ref={inputRef}
        type="text"
        placeholder="Enter username"
        style={{ padding: "8px", marginRight: "10px" }}
      />
      <button>Submit</button>
    </div>
  );
}

export default LoginForm;
