import { useRef } from "react";

function UncontrolledInput(){

    const handleForm = (event)=>{
        event.preventDefault();

        const user = document.querySelector('#user').value;
        const password = document.querySelector('#password').value;
        console.log(user, password);
        
    }

    const userRef = useRef();
    const passwordRef = useRef();
    const handleFormRef = (event)=>{
        event.preventDefault();
        const user = userRef.current.value;
        const password = passwordRef.current.value;

        console.log(user, password);
        
    }

    return(
        <>
            <h1>Uncontrolled Component</h1>
            <form action="" method="post" onSubmit={handleForm}>

                <input type="text" name="" id="user"  placeholder="Enter user name" />
                <br /><br />

                <input type="password" name="" id="password" placeholder="Enter password" />
                <br /><br />

                <button>Submit</button>

            </form>

            <br />
            <br />

            <h1>Uncontrolled Component with useRef Hook</h1>
            <form action="" method="post" onSubmit={handleFormRef}>

                <input type="text" name="" id="userRef" ref={userRef} placeholder="Enter user name" />
                <br /><br />

                <input type="password" name="" id="passwordRef" ref={passwordRef} placeholder="Enter password" />
                <br /><br />

                <button>Submit</button>

            </form>
        </>
    )
}

export default UncontrolledInput;