import React from "react";
import { GoogleMap, Marker, useLoadScript } from "@react-google-maps/api";

import './DeliveryDetails.scss';

const mapContainerStyle = {
  width: '100%',
  height: '58vh',
};

const center = {
  lat: 51.4485637,
  lng: 5.3691099,
};

export const DeliveryDetails = () => {
  const { isLoaded, loadError } = useLoadScript({
    googleMapsApiKey: process.env.REACT_APP_GOOGLE_MAPS_API_KEY as string
  });

  if (loadError) {
    return <div>Error loading maps</div>;
  }

  if (!isLoaded) {
    return <div>Loading maps</div>;
  }

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
            <input type="text" className="form-control streetInp" placeholder="Street*"/>
          </div>
          <div className="col-md-4">
            <input type="text" className="form-control streetInp" placeholder="№ house*"/>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 paddingleft0">
            <textarea rows={4} className="form-control streetInp"
                      placeholder="Comments for delivery address"/>
          </div>
        </div>
        <div className="row my-3">
          <div className="col-md-12 sub-header">
            <GoogleMap
              mapContainerStyle={mapContainerStyle}
              zoom={11}
              center={center}
            >
              <Marker position={center}/>
            </GoogleMap>
          </div>
        </div>
      </div>
    </>
  );
};