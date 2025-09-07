 
/* eslint-disable no-unsafe-optional-chaining */
/* eslint-disable no-unused-vars */
import Shimmer from "./Shimmer";
import { useParams } from "react-router-dom";
import useRestaurantMenu from "../utils/useRestaurantMenu";

const RestaurantMenu = () => {
  // const [resInfo, setResInfo] = useState(null);

  const { resId } = useParams(); //811707 , 1072777, 203925

  const resInfo = useRestaurantMenu(resId);

  if (resInfo === null) return <Shimmer />;

  const {
    name,
    cuisines,
    costForTwoMessage,
    avgRating,
    sla,
    totalRatingsString,
  } = resInfo?.cards[2]?.card?.card?.info;

  const { itemCards } =
    resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR?.cards[1]?.card?.card; //itemCards is missing in some rest.

  const { carousel } =
    resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR?.cards[1]?.card?.card;

  return (
    <div className="menu">
      <h1>{name}</h1>
      <p>{cuisines.join(" ,")} - {costForTwoMessage}</p><br /><br />

      <h3>Menu</h3>
      <ul>
        {/* <li>{itemCards[0].card.info.name}</li> */}
        {itemCards?.map((item) => (
          <li key={item?.card?.info?.id}>
            {item?.card?.info?.name} - Rs.{" "}
            {item?.card?.info?.price / 100 || item?.card?.info?.defaultPrice / 100}
          </li>
        )) || 
          carousel?.map((item) => (
          <li key={item?.dish?.info?.id}>
            {item?.dish?.info?.name} - Rs.{" "}
            {item?.dish?.info?.price / 100 || item?.dish?.info?.defaultPrice / 100}
          </li>
        ))
        }
      </ul>
    </div>
  );
};

export default RestaurantMenu;
