import React from "react";

import PizzaIcon1 from '../../../assets/cards/home/pizza-icon-1.png';
import PizzaIcon2 from '../../../assets/cards/home/pizza-icon-2.png';
import PizzaIcon3 from '../../../assets/cards/home/pizza-icon-3.png';

import './HomeComponent.scss';

export const HomeComponent = () => {
  return (
    <>
      <div className="container my-5">
        <div className="row">
          <div className="col-md-12 pizza-component-header">
            <p className="mt-4 mb-4">Pizza</p>
          </div>
        </div>
        <div className="row">
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={PizzaIcon1} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="pizza-weight">
                  <p>540 <span>g</span></p>
                </div>
                <div className="pizza-sizing">
                  <p>30 cm</p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Quattro Formaggi</h5>
            </div>
            <div className="col-md-12 text-center pizza-details-paragraph">
              <p>
                bechamel sauce, parmesan cheese, mozzarella cheese, ricotta
                cheese, dorblu cheese, walnut, pear.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 pizza-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>14.44</p><span>EUR</span>
              </div>
              <div className="d-flex align-items-center counter-section">
                <button className="button">-</button>
                <div className="amount">1</div>
                <button className="button">+</button>
              </div>
              <div className="d-flex align-items-end">
                <button className="order-button">Order</button>
              </div>
            </div>
          </div>
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={PizzaIcon2} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="pizza-weight">
                  <p>540 <span>g</span></p>
                </div>
                <div className="pizza-sizing">
                  <p>30 cm</p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Quattro Formaggi</h5>
            </div>
            <div className="col-md-12 text-center pizza-details-paragraph">
              <p>
                bechamel sauce, parmesan cheese, mozzarella cheese, ricotta
                cheese, dorblu cheese, walnut, pear.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 pizza-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>14.44</p><span>EUR</span>
              </div>
              <div className="d-flex align-items-center counter-section">
                <button className="button">-</button>
                <div className="amount">1</div>
                <button className="button">+</button>
              </div>
              <div className="d-flex align-items-end">
                <button className="order-button">Order</button>
              </div>
            </div>
          </div>
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={PizzaIcon3} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="pizza-weight">
                  <p>540 <span>g</span></p>
                </div>
                <div className="pizza-sizing">
                  <p>30 cm</p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Quattro Formaggi</h5>
            </div>
            <div className="col-md-12 text-center pizza-details-paragraph">
              <p>
                bechamel sauce, parmesan cheese, mozzarella cheese, ricotta
                cheese, dorblu cheese, walnut, pear.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 pizza-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>14.44</p><span>EUR</span>
              </div>
              <div className="d-flex align-items-center counter-section">
                <button className="button">-</button>
                <div className="amount">1</div>
                <button className="button">+</button>
              </div>
              <div className="d-flex align-items-end">
                <button className="order-button">Order</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}