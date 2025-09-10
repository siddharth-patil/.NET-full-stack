import { useState } from "react";
import ItemList from "./ItemList";

const RestaurantCategory = ({ data }) => {
  //   console.log(data);
  const [showItems, setShowItems] = useState(false);

  const handleClick = () =>{
    setShowItems(!showItems);
  }

  return (
    <div className="bg-light mx-auto w-50">
      {/* Header */}
      <div className="mx-auto mb-1 py-1 px-2 shadow-sm border-3 border-bottom border-5 border-black border-opacity-25">
        <div className="d-flex justify-content-between mb-3" style={{cursor:"pointer"}} onClick={handleClick}>
          <span className="fw-bold fs-5">
            {data.title} ({data.itemCards.length})
          </span>
          <span>🔽</span>
        </div>

        {/* Accordion Body */}
        {showItems && <ItemList items={data.itemCards} />}
      </div>
    </div>
  );
};

export default RestaurantCategory;
