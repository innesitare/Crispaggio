import React from "react";
import SaladIcon1 from '../../../assets/cards/salads/salads-icon-1.png';
import SaladIcon2 from '../../../assets/cards/salads/salads-icon-2.png';
import SaladIcon3 from '../../../assets/cards/salads/salads-icon-3.png';

import "./SaladsComponent.scss";

export const SaladsComponent = () => {
  return (
    <>
      <div className="container my-5">
        <div className="row">
          <div className="col-md-12 salads-component-header">
            <p className="mt-4 mb-4">Salads</p>
          </div>
        </div>
        <div className="row">
          <div className="col-md-4">
            <div className="col-md-12 image-section">
              <img src={SaladIcon1} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="salads-details-weight">
                  <p>300 <span>g</span></p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Caesario</h5>
            </div>
            <div className="col-md-12 text-center salads-details-paragraph">
              <p>
                Lettuce, tomatoes, chicken, parmesan cheese, quail eggs,
                croutons, and signature dressing - Caesar sauce.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 salads-details-pricing">
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
              <img src={SaladIcon2} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="salads-details-weight">
                  <p>300 <span>g</span></p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Salmon</h5>
            </div>
            <div className="col-md-12 text-center salads-details-paragraph">
              <p>
                rucola, cherry tomato, cucumber, iceberg lettuce, aioli sauce,
                parmesan, salmon, quail egg, sesame.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 salads-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>14.44</p><span>EUR</span>
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
              <img src={SaladIcon3} className="img-fluid w-100 h-100" alt=""/>
              <div className="discount-section">
                <div className="salads-details-weight">
                  <p>300 <span>g</span></p>
                </div>
              </div>
            </div>
            <div className="col-md-12 text-center py-3">
              <h5 style={{ fontWeight: "bolder" }}>Cheesy</h5>
            </div>
            <div className="col-md-12 text-center salads-details-paragraph">
              <p>
                bechamel sauce, parmesan cheese, mozzarella cheese, ricotta
                cheese, dorblu cheese, walnut, pear.
              </p>
            </div>
            <hr/>
            <div className="col-md-12 px-4 py-2 salads-details-pricing">
              <div className="price-section d-flex align-items-end">
                <p>14.44</p><span>EUR</span>
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
        </div>
      </div>
    </>
  );
};