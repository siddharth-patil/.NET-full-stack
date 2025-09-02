import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import App from "./App.jsx";
import Body from "./components/Body.jsx";
import About from "./components/About.jsx";
import Contact from "./components/Contact.jsx";
import Error from "./components/Error.jsx";
import Header from "./components/Header.jsx";
import { createBrowserRouter, RouterProvider, Outlet } from "react-router-dom";

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
    ],
  },
  // {
  //   path: "/",
  //   element: <div><Header/><Body /></div> ,
  // },
  // {
  //   path: "/about",
  //   element: <div><Header/><About /></div>  ,
  // },
  // {
  //   path: "/contact",
  //   element: <div><Header/> <Contact /></div> ,
  // },
]);

createRoot(document.getElementById("root")).render(
  <StrictMode>
    {/* <App /> */}
    <RouterProvider router={appRouter} />
    {/* <Outlet/> */}
  </StrictMode>
);
