import React from "react";
import { Zones } from "./Zones/Zones";
import { Content } from "./Content/Content";
import { MapDetails } from "./MapDetails/MapDetails";
import { Map } from "../Map/Map";

import "./DeliveryInformationComponent.scss";

export const DeliveryInformationComponent = () => {
  return (
    <>
      <div className="container-fluid information-card-background my-5">
        <p className="information-card-header">Delivery zones in Eindhoven</p>
      </div>
      <div className="container">
        <div className="row pt-5">
          <Zones/>
          <div className="col-md-6">
            <div className="row">
              <div className="col-md-12">
                <MapDetails/>
              </div>
            </div>
            <div className="row mt-4">
              <div className="col-md-12">
                <div>
                  <Map style={{ "width": 640, "height": 640 }}/>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div className="row my-5 pb-5">
          <Content/>
        </div>
      </div>
    </>
  );
};
