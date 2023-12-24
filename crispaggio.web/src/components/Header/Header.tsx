import React from "react";
import LogoIcon from '../../assets/header/logo-icon.png'
import PizzaIcon from '../../assets/header/pizza-icon.png'
import SushiIcon from '../../assets/header/sushi-icon.png'
import SaladsIcon from '../../assets/header/salads-icon.png'
import DessertsIcon from '../../assets/header/desserts-icon.png'
import DrinksIcon from '../../assets/header/drinks-icon.png'
import InformationIcon from '../../assets/header/information-icon.png'
import LocationIcon from '../../assets/header/location-icon.png'
import CartIcon from '../../assets/header/cart-icon.png'

import { NavLink } from "react-router-dom"

import "./Header.scss";

export const Header: React.FC = () => {
  return (<>
      <div className="container-fluid header">
        <div className="container">
          <div className="row align-items-center">
            <div className="col-lg-8 col-md-12 responsive-row col-sm-12 d-flex align-items-center">
              <NavLink to="/">
                <img alt="Link" src={LogoIcon}/>
              </NavLink>
              <div className="d-flex align-items-center hide-text-decoration"
                   style={{ position: "relative", left: "15px" }}>
                <NavLink to="/">
                  <div className="d-flex align-items-center flex-column link-button-navigate">
                    <img src={PizzaIcon} alt="Menu Icon 2"/>
                    <h6 style={{ color: "#000000" }}>Pizza</h6>
                  </div>
                </NavLink>
                <NavLink to="/sushi">
                  <div className="d-flex align-items-center flex-column link-button-navigate">
                    <img src={SushiIcon} alt="Sushi"/>
                    <h6 style={{ color: "#000000" }}>Sushi</h6>
                  </div>
                </NavLink>
                <NavLink to="/salads">
                  <div className="d-flex align-items-center flex-column link-button-navigate">
                    <img src={SaladsIcon} alt="Menu Icon 3"/>
                    <h6 style={{ color: "#000000" }}>Salads</h6>
                  </div>
                </NavLink>
                <NavLink to="/desserts">
                  <div className="d-flex align-items-center flex-column link-button-navigate">
                    <img src={DessertsIcon} alt="Deserty"/>
                    <h6 style={{ color: "#000000" }}>Desserts</h6>
                  </div>
                </NavLink>
                <NavLink to="/drinks">
                  <div className="d-flex align-items-center flex-column link-button-navigate">
                    <img src={DrinksIcon} alt="Menu Icon 4"/>
                    <h6 style={{ color: "#000000" }}>Drinks</h6>
                  </div>
                </NavLink>
                <NavLink to="/information">
                  <div className="d-flex align-items-center flex-column link-button-navigate">
                    <img src={InformationIcon} alt="Menu Icon 5"/>
                    <h6 style={{ color: "#000000" }}>Information</h6>
                  </div>
                </NavLink>
              </div>
            </div>
            <div className="col-lg-4 col-md-0 col-sm-0 text-right header-right">
              <div className="row align-items-center h-100 ">
                <div className="col-lg-4 d-flex align-items-center h-100 w-auto">
                  <img src={LocationIcon} alt="Location"/>
                  <h6 style={{ paddingLeft: '20px', paddingTop: '15px' }}>Eindhoven</h6>
                </div>
                <div className="col-lg-2 d-flex align-items-center flex-column sign-in-anchor">
                  <NavLink to="/checkout">
                    <img src={CartIcon} style={{ paddingLeft: '15px' }} alt="Cart"/>
                  </NavLink>
                </div>
                <div className="col-lg-2 d-flex align-items-center h-100 w-auto sign-in-anchor">
                  <NavLink to="/personal-account">
                    <h6>Sign in</h6>
                  </NavLink>
                </div>
                <div className="col-lg-3 d-flex align-items-center h-100 w-auto sign-in-anchor">
                  <h6 style={{ paddingTop: '15px' }}>Eng <i className="fa fa-angle-down" aria-hidden="true"></i></h6>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};