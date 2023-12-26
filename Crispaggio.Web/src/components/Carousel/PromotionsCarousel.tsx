import React from "react";
import { Carousel } from "react-bootstrap";

import DeliveryPromotionImage from '../../assets/carousel/delivery-promotion.png';
import OfferPromotionImage from '../../assets/carousel/offer-promotion.png';

import "./PromotionsCarousel.scss";

export const PromotionsCarousel = () => {
  return (
    <>
      <div className="container mt-5">
        <div className="row">
          <div className="col-md-12">
            <Carousel>
              <div className="carousel-inner">
                <div className="carousel-item active">
                  <div className="row">
                    <div className="col-6">
                      <img src={DeliveryPromotionImage} className="d-block w-100" alt="..."/>
                    </div>
                    <div className="col-6">
                      <img src={OfferPromotionImage} className="d-block w-100" alt="..."/>
                    </div>
                  </div>
                </div>
                <div className="carousel-item">
                  <div className="row">
                    <div className="col-6">
                      <img src={DeliveryPromotionImage} className="d-block w-100" alt="..."/>
                    </div>
                    <div className="col-6">
                      <img src={OfferPromotionImage} className="d-block w-100" alt="..."/>
                    </div>
                  </div>
                </div>
              </div>
            </Carousel>
          </div>
        </div>
      </div>
    </>
  );
};
