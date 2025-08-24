// import { useState } from "react";
import React from "react";
import './Todo.css'

class Todo extends React.Component {
  constructor() {
    super();
    this.state = {
      show: true,
    }
  }

  msgPopup() {
    alert("Tasks completed!");
  };

  toggleState=()=>{
    this.setState((prevState)=>({
        show:!prevState.show
    }));
  };

  render() {
    return (
      <div>
        {this.state.show && <h2>To-do list for Today</h2>}
        <img src="vite.svg" height={100} alt="" />
        <ul>
          <li>Lorem ipsum dolor sit amet consectetur.</li>
          <li>Lorem ipsum dolor sit amet.</li>
          <li>Lorem ipsum dolor sit amet consectetur adipisicing.</li>
          <li>Lorem ipsum dolor sit.</li>
          <li>Lorem ipsum dolor sit amet consectetur.</li>
        </ul>
        <button onClick={this.msgPopup}>Mark Task</button> &nbsp;
        <button onClick={this.toggleState}>Toggle Name</button>
      </div>
    );
  }
}

export default Todo;


  // chatGPT T0\o-do App
  //     const [todos, setTodos] = useState([]);
  //   const [task, setTask] = useState("");

  //   Add task
  //   const addTodo = () => {
  //     if (task.trim() === "") return;
  //     setTodos([...todos, { id: Date.now(), text: task, completed: false }]);
  //     setTask("");
  //   };

  //   Toggle complete
  //   const toggleTodo = (id) => {
  //     setTodos(
  //       todos.map((todo) =>
  //         todo.id === id ? { ...todo, completed: !todo.completed } : todo
  //       )
  //     );
  //   };

  //   Delete task
  //   const deleteTodo = (id) => {
  //     setTodos(todos.filter((todo) => todo.id !== id));
  //   };

  //   return (
  //     <div className="flex flex-col items-center min-h-screen bg-gray-100 p-6">
  //       <h1 className="text-3xl font-bold mb-6">✅ To-Do App</h1>

  //       {/* Input Box */}
  //       <div className="flex gap-2 mb-6">
  //         <input
  //           type="text"
  //           value={task}
  //           onChange={(e) => setTask(e.target.value)}
  //           placeholder="Enter a task..."
  //           className="p-2 rounded-lg border border-gray-400 w-64"
  //         />
  //         <button
  //           onClick={addTodo}
  //           className="px-4 py-2 bg-blue-600 text-white rounded-lg"
  //         >
  //           Add
  //         </button>
  //       </div>

  //       {/* Task List */}
  //       <ul className="w-80">
  //         {todos.map((todo) => (
  //           <li
  //             key={todo.id}
  //             className="flex justify-between items-center bg-white p-3 rounded-lg shadow mb-2"
  //           >
  //             <span
  //               onClick={() => toggleTodo(todo.id)}
  //               className={`cursor-pointer ${
  //                 todo.completed ? "line-through text-gray-500" : ""
  //               }`}
  //             >
  //               {todo.text}
  //             </span>
  //             <button
  //               onClick={() => deleteTodo(todo.id)}
  //               className="text-red-600 font-bold"
  //             >
  //               ✕
  //             </button>
  //           </li>
  //         ))}
  //       </ul>
  //     </div>
  //   );

