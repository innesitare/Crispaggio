import React from "react";
import { Map } from "../../../Map/Map";

import './DeliveryDetails.scss';

export const DeliveryDetails = () => {
  return (
    <>
      <div className="col-md-6 px-4">
        <div className="row">
          <div className="col-md-12 background-delivery-method">
            <p className="delivery-method-header">Delivery method</p>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 sub-header">
            <div className="radio-item">
              <input type="radio" id="ritema" name="ritem" value="ropt1"/>
              <label htmlFor="ritema" className="label">Delivery</label>
            </div>
            <div className="radio-item">
              <input type="radio" id="ritemb" name="ritem" value="ropt2"/>
              <label htmlFor="ritemb" className="label">Pickup</label>
            </div>
            <div className="radio-item">
              <input type="radio" id="ritemc" name="ritem" value="ropt3"/>
              <label htmlFor="ritemc" className="label">Previously</label>
            </div>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 sub-header">
            <input type="text" className="form-control form-input" placeholder="Your name*"/>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 sub-header">
            <input type="text" className="form-control form-input" placeholder="Phone number*"/>
            <label htmlFor="" className="phone-label">You are not registered, <span
              className="">log in</span> to redeem the bonuses.</label>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-8 paddingleft0">
            <input type="text" className="form-control form-input" placeholder="Street*"/>
          </div>
          <div className="col-md-4">
            <input type="text" className="form-control form-input" placeholder="№ house*"/>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 paddingleft0">
            <textarea rows={4} className="form-control form-input"
                      placeholder="Comments for delivery address"/>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 sub-header">
            <Map style={{ "width": 615, "height": 400 }}/>
          </div>
        </div>
      </div>
    </>
  );
};