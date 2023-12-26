import React, { useState } from "react";
import ReactMapGL, { GeolocateControl } from 'react-map-gl';

type MapStyleProp = {
  width: number;
  height: number;
}

export const Map: React.FC<{ style: MapStyleProp }> = ({ style }) => {
  const [viewPort] = useState({
    longitude: 4.55,
    latitude: 52.23,
    zoom: 6.5,
  });

  return (
    <>
      <ReactMapGL
        initialViewState={viewPort}
        style={style}
        mapboxAccessToken={process.env.REACT_APP_MAPBOX_API_KEY}
        mapStyle="mapbox://styles/mapbox/streets-v12"
      >
        <GeolocateControl
          positionOptions={{ enableHighAccuracy: true }}
          trackUserLocation={true}
        />
      </ReactMapGL>
    </>
  );
}