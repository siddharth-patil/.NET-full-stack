/* eslint-disable react-refresh/only-export-components */
import { CDN_URL } from "../utils/restList";

function RestaurantCard(props) {
  const resData = props;
  const {
    name,
    cuisines,
    avgRating,
    costForTwo,
    cloudinaryImageId,
    areaName,
    sla,
  } = resData.resObj.info;
  return (
    <div className="res-card" style={{ backgroundColor: "#ffffffff" }}>
      <img
        className="res-logo"
        src={CDN_URL + cloudinaryImageId}
        alt="res-logo"
      />
      <div className="res-card-info">
        <b
          style={{ fontSize: "1.25rem", color: "black" }}
          className="card-text-overflow"
        >
          {name}
        </b>
        {/* <p className="card-text-overflow">{cuisines.join(", ")}</p> */}
        {/* <p>{avgRating} stars - {resData.resObj.info.sla.deliveryTime} minutes</p> */}
        <p>
          {avgRating} stars - {sla.slaString}
        </p>
        <p>{costForTwo}</p>
        {/* <p>{resData.resObj.info.sla.deliveryTime} minutes</p> */}
        <p className="card-text-overflow">{cuisines.join(", ")}</p>
        <small className="card-text-overflow">{areaName}</small>
      </div>
    </div>
  );
}

// Higher order component

//input -> RestaurantCard =>> RestaurantCardPromoted

export const withTimeLabel = () => {
  return (props) => {
    return (
      <div>
        <label className="position-absolute bg-black m-2 p-1 text-white">{props.resObj.info.sla.deliveryTime} minutes</label>
        <RestaurantCard {...props} />
      </div>
    );
  };
};

export default RestaurantCard;
