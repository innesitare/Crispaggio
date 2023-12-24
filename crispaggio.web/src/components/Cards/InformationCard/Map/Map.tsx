import React, { FC } from "react";
import { GoogleMap, useLoadScript, Marker } from '@react-google-maps/api';
import { MapOptions } from "./MapOptions";

const mapContainerStyle: React.CSSProperties = {
  width: '100%',
  height: '83vh',
};

const center: { lat: number, lng: number } = {
  lat: 51.4485637,
  lng: 5.3691099,
};

export const Map: FC = () => {
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
      <div className="col-md-6">
        <div className="row">
          <div className="col-md-12">
            <MapOptions/>
          </div>
        </div>
        <div className="row mt-4">
          <div className="col-md-12">
            <div>
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
      </div>
    </>
  );
};