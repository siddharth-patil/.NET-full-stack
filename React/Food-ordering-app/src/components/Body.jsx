import RestaurantCard from "./RestaurantCard";
// import { restList } from "../utils/mockData";
import { useEffect, useState } from "react";
import Shimmer from "./Shimmer";
import { Link } from "react-router-dom";

function Body() {
  const [listOfRestaurants, setListOfRestaurants] = useState([]);
  const [FilteredlistOfRestaurants, setFilteredlistOfRestaurants] = useState(
    []
  );

  const [searchedText, setSearchedText] = useState("");

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    const data = await fetch(
      "api/dapi/restaurants/list/v5?lat=18.657473655994714&lng=73.7543744585405&is-seo-homepage-enabled=true&page_type=DESKTOP_WEB_LISTING"
    );

    const json = await data.json();
    // console.log(json);
    // console.log(json.data.cards[1].card.card.gridElements.infoWithStyle.restaurants);
    const list1 =
      json?.data?.cards[1]?.card?.card?.gridElements?.infoWithStyle
        ?.restaurants;
    // const list2 = json.data.cards[4].card.card.gridElements.infoWithStyle.restaurants;
    // const combinedArr = list1.concat(list2);
    // setListOfRestaurants(combinedArr);
    setListOfRestaurants(list1);
    setFilteredlistOfRestaurants(list1);
  };

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
         <Link key={restaurant?.info.id} to={"/restaurants/" + restaurant?.info.id}> <RestaurantCard resObj={restaurant} /> </Link>
        ))}
      </div>
    </div>
  );
}

export default Body;
