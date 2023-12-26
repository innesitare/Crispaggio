import React from "react";
import templatePizzaIcon from "../../../../assets/orders/template-pizza-icon.png";
import crossIcon from "../../../../assets/orders/cross-icon.png";

import './PaymentDetails.scss';

export const PaymentDetails = () => {
  return (
    <>
      <div className="col-md-6 px-4 mt-3">
        <div className="row">
          <div className="col-md-6 col-6">
            <p className="details-column">Product</p>
          </div>
          <div className="col-md-3 col-3">
            <p className="details-column text-center">Amount</p>
          </div>
          <div className="col-md-3 col-3">
            <p className="details-column text-center">Price</p>
          </div>
        </div>
        <div className="order-item-header">
          <div className="row order-item-border-box">
            <div className="col-md-6 col-6" style={{ paddingLeft: '5px' }}>
              <div className="order-item-box"><img src={templatePizzaIcon} alt=""/><p className="order-item-name">Quattro
                Formaggi</p></div>
            </div>
            <div className="col-md-3 col-3 amount-counter">
              <div className="d-flex align-items-center">
                <button className="button">-</button>
                <div className="value">1</div>
                <button className="button">+</button>
              </div>
            </div>
            <div className="col-md-3 col-3 ">
              <p className="cross-icon"><img src={crossIcon} alt=""/></p>
              <p className="item-price">14,99 <span className="item-price-currency"> EUR</span></p>
            </div>
          </div>
        </div>
        <div className="order-price-header">
          <div className="row mt-2 mb-3">
            <div className="col-md-12 col-6">
              <p className="total-price">Together:<span> 14,99 EUR</span></p>
            </div>
          </div>
        </div>
        <div className="order-details-header">
          <div className="row">
            <div className="col-md-12 section-background">
              <p className="section-header">Make an order</p>
            </div>
            <div className="row my-3">
              <div className="col-md-8 col-12 sub-header">
                <label htmlFor="" className="promo-code-label">Promo code</label>
                <input type="text" className="form-control form-input" placeholder="Enter a promo code"/>
              </div>
              <div className="col-md-4 col-12">
                <button className="activate-button">Activate</button>
              </div>
            </div>
          </div>
        </div>
        <div className="payment-header">
          <div className="row">
            <div className="col-md-12 section-background">
              <p className="section-header">Payment method</p>
            </div>
          </div>
          <div className="row mt-3">
            <div className="col-md-12 sub-header">
              <div className="radio-item">
                <input type="radio" id="ritema" name="ritem" value="ropt1"/>
                <label htmlFor="ritema" className="label">Cash</label>
              </div>
              <div className="radio-item">
                <input type="radio" id="ritemb" name="ritem" value="ropt2"/>
                <label htmlFor="ritemb" className="label">Online</label>
              </div>
              <div className="radio-item">
                <input type="radio" id="ritemc" name="ritem" value="ropt3"/>
                <label htmlFor="ritemc" className="label">Courier card</label>
              </div>
            </div>
          </div>
          <div className="row">
            <div className="col-md-6"></div>
            <div className="col-md-6">
              <p className="final-price">Together:<span> 14,99 EUR</span></p>
            </div>
          </div>
          <div className="row">
            <div className="col-md-8"></div>
            <div className="col-md-4 done-button-alignment">
              <button className="done-button">Done</button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};