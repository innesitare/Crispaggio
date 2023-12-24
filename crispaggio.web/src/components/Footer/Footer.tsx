import React from "react";
import FacebookIcon from '../../assets/footer/facebook-icon.png';
import EmailIcon from '../../assets/footer/email-icon.png'
import InstagramIcon from '../../assets/footer/instagram-icon.png'
import TelegramIcon from '../../assets/footer/telegram-icon.png'
import MobilePhoneIcon from '../../assets/footer/mobile-phone-icon.png'

import './Footer.scss'

export const Footer = () => {
  return (
    <>
      <div className="container-fluid py-5" style={{ backgroundColor: "#FFD600" }}>
        <div className="container">
          <div className="row">
            <div className="col-md-6 align-items-center d-flex">
              <div className="d-flex align-items-center">
                <div className="socialBox mx-2 py-1 px-2">
                  <img src={FacebookIcon} className="img-fluid" alt=""/>
                </div>
                <div className="socials-box mx-2 py-1 px-2">
                  <img src={EmailIcon} className="img-fluid" alt=""/>
                </div>
                <div className="socials-box mx-2 py-1 px-2">
                  <img src={InstagramIcon} className="img-fluid" alt=""/>
                </div>
                <div className="socials-box mx-2 py-1 px-2">
                  <img src={TelegramIcon} className="img-fluid" alt=""/>
                </div>
              </div>
            </div>
            <div className="col-md-4 mt-lg-0 mt-md-0 mt-4">
              <p className="address-header">Eindhoven</p>
              <p className="address-paragraph">Laarderweg 83</p>
              <p className="address-paragraph">Tramstraat 18</p>
            </div>
            <div className="col-md-2 mt-lg-0 mt-md-0 mt-4">
              <p className="contact-number-paragraph"><img src={MobilePhoneIcon} className="img-fluid phone-icon" alt=""/>062 488 45 23</p>
              <p className="mobile-app-paragraph">Download the mobile app</p>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};