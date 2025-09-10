/* eslint-disable no-unsafe-optional-chaining */
/* eslint-disable no-unused-vars */
import Shimmer from "./Shimmer";
import { useParams } from "react-router-dom";
import useRestaurantMenu from "../utils/useRestaurantMenu";
import RestaurantCategory from "./RestaurantCategory";

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

  // console.log(resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR?.cards);

  const categories =
    resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR?.cards.filter(
      (c) =>
        c.card.card["@type"] ===
        "type.googleapis.com/swiggy.presentation.food.v2.ItemCategory"
    );

  console.log(resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR);

  //  console.log(categories1);

  // const { carousel } =
  //   resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR?.cards[1]?.card?.card;
  //   console.log(carousel);

  return (
    <div className="menu text-center">
      <h1 className="fw-bold">{name}</h1>
      <p className="fw-bold text-md-center my-0">
        {cuisines.join(", ")} - {costForTwoMessage}
      </p>
      <br />
      <br />

      {categories.map((category) => (
        <RestaurantCategory
          key={category?.card?.card?.categoryId}
          data={category?.card?.card}
        />
      ))}

      {/* <h3>Menu</h3> */}
      {/* <ul> */}
      {/* <li>{itemCards[0].card.info.name}</li> */}
      {/* {itemCards?.map((item) => (
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
        } */}
      {/* </ul> */}
    </div>
  );
};

export default RestaurantMenu;
