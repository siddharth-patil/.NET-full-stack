import { useState } from "react";

function Input(){
    const [val, setVal] = useState('Ram');
    const [pass, setPass] = useState('');
    const [email, setEmail] = useState('');

    return(
        <div>
            <h1>Get input field values</h1>

            <input type="text" value={val} onChange={(event)=>setVal(event.target.value)} placeholder="Enter Username" name="" id="" />
            {/* <h3>{val}</h3> */}
            <br />
            <input type="password" value={pass} onChange={(event)=>setPass(event.target.value)} placeholder="Enter Password" name="" id="" />
            <br />
             <input type="text" value={email} onChange={(event)=>setEmail(event.target.value)} placeholder="Enter Email" name="" id="" />
            <br />
            <button onClick={()=>{setVal('');
                setPass(''); setEmail('');
            }}>Clear</button>
            <button onClick={()=>alert('Name : ' + val + '\n' + 
                    'Password : ' + pass + '\n' + 
                    'Email : ' + email
            )}>Submit</button>
        </div>
    )
}

export default Input;