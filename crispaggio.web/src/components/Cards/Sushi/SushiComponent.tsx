import React from "react";
import SushiIcon1 from '../../../assets/cards/sushi/sushi-icon-1.png';
import SushiIcon2 from '../../../assets/cards/sushi/sushi-icon-2.png';
import SushiIcon3 from '../../../assets/cards/sushi/sushi-icon-3.png';

import './SushiComponent.scss';

export const SushiComponent = () => {
  return (
    <>
      <div className="container my-5">
        <div className="row">
          <div className="col-md-12 sushi-component-header">
            <p className="mt-4 mb-4">Sushi</p>
          </div>
        </div>
        <div className="row">
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={SushiIcon1} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="sushi-details-weight">
                  <p>890 <span>g</span></p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Luxury set</h5>
            </div>
            <div className="col-md-12 text-center sushi-details-paragraph">
              <p>
                California with a shrimp, banza with fried salmon, Canada
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 sushi-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>23,99</p><span>EUR</span>
              </div>
              <div className="d-flex align-items-center counter-section">
                <button className="button">-</button>
                <div className="amount">1</div>
                <button className="button">+</button>
              </div>
              <div className="price-section-button d-flex align-items-end">
                <button className="order-button">Order</button>
              </div>
            </div>
          </div>
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={SushiIcon2} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="sushi-details-weight">
                  <p>840 <span>g</span></p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Set Philadelphia</h5>
            </div>
            <div className="col-md-12 text-center sushi-details-paragraph">
              <p>
                bechamel sauce, parmesan cheese, mozzarella cheese, ricotta
                cheese, dorblu cheese, walnut, pear.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 sushi-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>23,99</p><span>EUR</span>
              </div>
              <div className="d-flex align-items-center counter-section">
                <button className="button">-</button>
                <div className="amount">1</div>
                <button className="button">+</button>
              </div>
              <div className="price-section-button d-flex align-items-end">
                <button className="order-button">Order</button>
              </div>
            </div>
          </div>
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={SushiIcon3} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="sushi-details-weight">
                  <p>920 <span>g</span></p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Set Philadelphia Deluxe</h5>
            </div>
            <div className="col-md-12 text-center sushi-details-paragraph">
              <p>
                bechamel sauce, parmesan cheese, mozzarella cheese, ricotta
                cheese, dorblu cheese, walnut, pear.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 sushi-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>25,99</p><span>EUR</span>
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
};