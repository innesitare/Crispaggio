import React from 'react';

// @ts-ignore
export const CarouselItem = ({ image }) => {
  return (
    <div className="carousel-item">
      <img src={image} className="d-block w-100" alt="..."/>
    </div>
  );
};
