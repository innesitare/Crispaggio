import React from "react";
import DeliveryPromotionIcon from '../../assets/carousel/delivery-promotion.png';
import OfferPromotionIcon from '../../assets/carousel/offer-promotion.png';
import { CarouselItem } from "./CarouselItem";

import "./Carousel.scss";

export const Carousel = () => {
  return (
    <>
      <div className="container mt-5">
        <div className="row">
          <div className="col-md-12">
            <div id="carouselExampleIndicators" className="carousel slide">
              <div className="carousel-indicators">
                <button
                  type="button"
                  data-bs-target="#carouselExampleIndicators"
                  data-bs-slide-to={0}
                  className="active"
                  aria-current="true"
                  aria-label="Slide 1"
                />
                <button
                  type="button"
                  data-bs-target="#carouselExampleIndicators"
                  data-bs-slide-to={1}
                  aria-label="Slide 2"
                />
                <button
                  type="button"
                  data-bs-target="#carouselExampleIndicators"
                  data-bs-slide-to={2}
                  aria-label="Slide 3"
                />
              </div>
              <div className="carousel-inner">
                <CarouselItem image={DeliveryPromotionIcon}/>
                <CarouselItem image={OfferPromotionIcon}/>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};
