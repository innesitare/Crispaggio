import React from "react";
import { Map } from "./Map/Map"
import { Zones } from "./Zones/Zones";
import { Content } from "./Content/Content";

import "./InformationCard.scss";

export const InformationCard = () => {
  return (
    <>
      <div className="container-fluid information-card-background my-5">
        <p className="information-card-header">Delivery zones in Eindhoven</p>
      </div>
      <div className="container">
        <div className="row pt-5">
          <Zones/>
          <Map/>
        </div>
        <div className="row my-5 pb-5">
          <Content/>
        </div>
      </div>
    </>
  );
};
