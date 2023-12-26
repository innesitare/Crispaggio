import React from "react";

import "./Zones.scss";

export const Zones = () => {
  return (
    <>
      <div className="col-md-6 mt-5 px-5">
        <div className="row">
          <div className="col-md-12 text-center pb-4">
            <p className="green-zone-header">Green zone</p>
            <p className="zone-paragraph mb-1">Up to <span className="zone-details-span">29 minutes</span></p>
            <p className="zone-paragraph my-1">Minimum order <span className="zone-details-span">10 EUR</span></p>
            <p className="zone-paragraph">We deliver FREE OF CHARGE</p>
          </div>
          <hr/>
        </div>
        <div className="row mt-5">
          <div className="col-md-12 text-center pb-4 mt-4">
            <p className="yellow-zone-header">Yellow zone</p>
            <p className="zone-paragraph mb-1">Up to <span className="zone-details-span">59 minutes</span></p>
            <p className="zone-paragraph my-1">Minimum order <span className="zone-details-span">20 EUR</span></p>
            <p className="zone-paragraph">Delivery cost is 5 EUR</p>
          </div>
          <hr/>
        </div>
        <div className="row mt-5">
          <div className="col-md-12 text-center pb-4 mt-4">
            <p className="blue-zone-header">Blue zone</p>
            <p className="zone-paragraph mb-1">Up to <span className="zone-details-span">89 minutes</span></p>
            <p className="zone-paragraph my-1">Minimum order <span className="zone-details-span">25 EUR</span></p>
            <p className="zone-paragraph">Delivery cost is 5 EUR</p>
          </div>
        </div>
      </div>
    </>
  );
};
