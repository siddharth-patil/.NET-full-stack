function Todo(){
    function msgPopup(){
        alert('Tasks completed!');
    }


    return(
        <div>
            <h2>To-do list for Today</h2>
            <img src="vite.svg" height={100} alt="" />
            <ul>
                <li>Lorem ipsum dolor sit amet consectetur.</li>
                <li>Lorem ipsum dolor sit amet.</li>
                <li>Lorem ipsum dolor sit amet consectetur adipisicing.</li>
                <li>Lorem ipsum dolor sit.</li>
                <li>Lorem ipsum dolor sit amet consectetur.</li>
            </ul>
        </div>
    )

}

export default Todo;