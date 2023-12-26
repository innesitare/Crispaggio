import React from "react";

import "./MapDetails.scss";

export const MapDetails: React.FC = () => {
  return (
    <>
      <div className="row">
        <div className="col-md-9">
          <input type="text" className="form-control form-input" placeholder="Street"/>
        </div>
        <div className="col-md-3">
          <input type="text" className="form-control form-input" placeholder="№ house"/>
        </div>
      </div>
    </>
  );
};