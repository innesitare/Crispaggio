import React from "react";

import { DeliveryDetails } from "./DeliveryDetails/DeliveryDetails";
import { PaymentDetails } from "./PaymentDetails/PaymentDetails";

import './OrderCard.scss';
                                                                    
export const OrderCard = () => {
  return (
    <>
      <div className="container-fluid order-card-background my-5">
        <p className="order-card-header">Your order</p>
      </div>
      <div className="container mb-5">
        <div className="row pb-5">
          <DeliveryDetails/>
          <PaymentDetails/>
        </div>
      </div>
    </>
  );
};
