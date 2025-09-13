import { useDispatch, useSelector } from "react-redux";
import ItemList from "./ItemList";
import { clearCart } from "../utils/cartSlice";


const Cart = ()=>{

    const cartItems = useSelector((store) => store.cart.items);

    const dispatch = useDispatch();

    const handleClearCart = ()=>{
        dispatch(clearCart());
    }

    return <div className="text-center mx-auto my-2 p-3">
        <h1 className="fw-bolder mx-auto">Cart</h1>
        <div className="w-50 my-1 mx-auto">
            <button className="p-2 m-2 bg-black text-white rounded"
            onClick={handleClearCart}>Clear Cart</button>
            {cartItems.length === 0 && <h3>Cart is empty. Try something tasty today!!</h3>}
            <ItemList  items={cartItems}/>
        </div>
    </div>
}

export default Cart;