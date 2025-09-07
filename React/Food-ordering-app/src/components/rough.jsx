/* eslint-disable no-unused-vars */
import RestaurantCard from "./RestaurantCard";
// import { restList } from "../utils/mockData";
import { useEffect, useState } from "react";
import Shimmer from "./Shimmer";
import { Link } from "react-router-dom";
import useResList from "../utils/useResList";

function Body() {
  // const [listOfRestaurants, setListOfRestaurants] = useState([]);
  
  const listOfRestaurants = useResList();
  
  const [FilteredlistOfRestaurants, setFilteredlistOfRestaurants] = useState([]);

  const [searchedText, setSearchedText] = useState("");

  const handleSearch = () => {
    const filteredResList = listOfRestaurants.filter((res) =>
      res.info.name.toLowerCase().includes(searchedText.toLowerCase())
    );
    setFilteredlistOfRestaurants(filteredResList);
  };

  const handleEnter = (event) => {
    if (event.key === "Enter") {
      handleSearch();
    }
  };

  //Conditional rendering
  // if (listOfRestaurants.length === 0) {
  //   return <Shimmer />;
  // }

  return listOfRestaurants.length === 0 ? (
    <Shimmer />
  ) : (
    <div className="body">
      <div className="filter">
        <div className="search">
          <input
            type="text"
            className="search-box"
            value={searchedText}
            onChange={(event) => setSearchedText(event.target.value)}
            onKeyDown={handleEnter}
          />
          <button onClick={handleSearch}>Search</button>
        </div>

        <button
          className="filter-btn"
          onClick={() => {
            //filter logic
            setFilteredlistOfRestaurants(
              listOfRestaurants.filter((res) => res.info.avgRating > 4.3)
            );
          }}
        >
          Top Rated Restaurants
        </button>
      </div>
      <div className="res-container">
        {FilteredlistOfRestaurants.map((restaurant) => (
          <Link
            className="link"
            key={restaurant?.info.id}
            to={"/restaurants/" + restaurant?.info.id}
          >
            {" "}
            <RestaurantCard resObj={restaurant} />{" "}
          </Link>
        ))}
      </div>
    </div>
  );
}

export default Body;
