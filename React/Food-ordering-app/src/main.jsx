import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import App from "./App.jsx";
import Body from "./components/Body.jsx";
import About from "./components/About.jsx";
import Contact from "./components/Contact.jsx";
import Error from "./components/Error.jsx";
import Header from "./components/Header.jsx";
import { createBrowserRouter, RouterProvider, Outlet, BrowserRouter } from "react-router-dom";
import RestaurantMenu from "./components/RestaurantMenu.jsx";

const appRouter = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <Error />,
    children: [
      {
        index:true,
        element: (
          <div>
            <Body />
          </div>
        ),
      },
      {
        path: "/about",
        element: (
          <div>
            <About />
          </div>
        ),
      },
      {
        path: "/contact",
        element: (
          <div>
           <Contact />
          </div>
        ),
      },
      {
        path:"/restaurants/:resId",
        element:<RestaurantMenu/>
      }
    ],
  },

]);

createRoot(document.getElementById("root")).render(
  <StrictMode>
    {/* <App /> */}
    <RouterProvider router={appRouter} />
    {/* <Outlet/> */}
  </StrictMode>

  // <BrowserRouter>
  //   <App/>
  // </BrowserRouter>

);
