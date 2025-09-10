import { CDN_URL } from "../utils/restList";

/* eslint-disable no-unused-vars */
const ItemList = ({ items }) => {
  // console.log(items);

  return (
    <div>
      {items.map((item) => (
        <div key={item.card.info.id} className="border-bottom border-2 d-flex justify-content-between">
          <div className="w-75">
            <div className="text-sm-start">
              <span className="fw-bold">{item.card.info.name}</span>
              <span>
                {" "}
                ₹{" "}
                {item.card.info.price / 100 ||
                  item.card.info.defaultPrice / 100}
              </span>
            </div>
            <p className="text-sm-start small  fst-italic">
              {item.card.info.description}
            </p>
          </div>
          <div className="w-25">
            <button className="position-absolute z-1 mx-lg-4 px-2 border-0 rounded bg-opacity-75 bg-info">Add</button>
            <img src={CDN_URL + item.card.info.imageId} className="w-50 my-2 rounded-3 position-relative" />
          </div>
        </div>
      ))}
    </div>
  );
};

export default ItemList;
