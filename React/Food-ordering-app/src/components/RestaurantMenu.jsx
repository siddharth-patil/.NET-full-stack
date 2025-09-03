/* eslint-disable react-hooks/exhaustive-deps */
/* eslint-disable no-unsafe-optional-chaining */
/* eslint-disable no-unused-vars */
import { useEffect, useState } from "react";
import Shimmer from "./Shimmer";
import { useParams } from "react-router-dom";
import { MENU_API } from "../utils/restList";

const RestaurantMenu = () => {
  const [resInfo, setResInfo] = useState(null);

  const {resId} = useParams(); //811707 , 1072777, 203925

  useEffect(() => {
    fetchMenu();
  }, []);

  const fetchMenu = async () => {
    const data = await fetch(
      MENU_API + resId
    );

    const json = await data.json();
    setResInfo(json.data);
    // console.log(
    //   json.data.cards[4].groupedCard.cardGroupMap.REGULAR.cards[1].card.card
    //     .itemCards
    // );
  };

  if (resInfo === null) return <Shimmer />;

  const {
    name,
    cuisines,
    costForTwoMessage,
    avgRating,
    sla,
    totalRatingsString,
  } = resInfo.cards[2].card.card.info;

   
  const { itemCards } =
    resInfo?.cards[4]?.groupedCard?.cardGroupMap?.REGULAR?.cards[1]?.card?.card; //itemCards is missing in some rest.

  return (
    <div className="menu">
      <h1>{name}</h1>
      <h2>{cuisines.join(" ,")}</h2>
      <ul>
        {/* <li>{itemCards[0].card.info.name}</li> */}
        {itemCards.map((item) => (
          <li key={item.card.info.id}>{item.card.info.name} - Rs. {item.card.info.price/100 || item.card.info.defaultPrice/100}</li>
        ))}
      </ul>
    </div>
  );
};

export default RestaurantMenu;
