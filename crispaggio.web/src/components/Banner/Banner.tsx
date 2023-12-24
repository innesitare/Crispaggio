import React from "react";
import LeftBanner from '../../../assets/banners/left-part-banner.png';
import RightBanner from '../../../assets/banners/right-part-banner.png';

import './Banner.scss';

export const Banner = () => {
  return (
    <>
      <div className="container-fluid mt-5">
        <div className="row px-0">
          <div className="col-md-2"></div>
          <div className="col-md-8 px-0">
            <div className="container px-0">
              <div className="row px-0">
                <img className="left-banner-svg p-0" src={LeftBanner} alt={"Banner"}/>
                <div className="col-md-12">
                  <p className="description-header mt-5">Wood-fired pizza Crispaggio in Eindhoven</p>
                  <p className="description-paragraph">A fast and most convenient for each client pizza delivery in
                    Eindhoven is
                    a service provided by Crispaggio at the highest level. At any time of the day, you can order a
                    delicious, aromatic pizza with a crispy crust, which is cooked in a wood-fired oven by the best
                    recipes. The quality of the dishes offered in the online catalog meets world-class standards. Each
                    bite gives our customers an unforgettable experience.
                    <br/><br/>
                    Do you want a piece of Italy to be on your holiday or office desk? Want to surprise friends, please
                    the kids or the loved ones? Then, without much hesitation, choose the pizza of your favorite taste
                    and place an order for our round-the-clock delivery to the desired address. A wide selection of
                    recipes, which you will find here, will surely satisfy your needs. Please note – you can add various
                    ingredients to your pizza, which are listed on the site.</p>
                  <p className="description-read-more">Read more</p>
                </div>
                <img className="right-banner-svg p-0" src={RightBanner} alt={"Banner"}/>
              </div>
            </div>
          </div>
          <div className="col-md-2"></div>
        </div>
      </div>
    </>
  );
};