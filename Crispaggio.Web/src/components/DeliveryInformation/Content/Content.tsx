import React from "react";
import InformationSymbolIcon from "../../../assets/information/information-icon.png"

import "./Content.scss";

export const Content = () => {
  return (
    <>
      <div className="col-md-1 d-flex justify-content-center" style={{ paddingRight: "0px" }}>
        <div className="icon-box bg-white text-center">
          <img src={InformationSymbolIcon} alt=""/>
        </div>
      </div>
      <div className="col-md-11" style={{ paddingLeft: "0px" }}>
        <p className="content-paragraph">
          The pizza delivery service Crispaggio in Eindhoven offers extremely convenient delivery and payment mechanism.
          We believe that our standards of work should be classic and comfortable for the customer.
          <br/>
          <br/>
          So, let’s start with delivery. We divide Eindhoven into delivery zones – <span
          style={{ color: "#309300", fontWeight: 700 }}>green</span>, <span
          style={{ color: "#F7C200", fontWeight: 700 }}>yellow</span> and <span
          style={{ color: "#309300", fontWeight: 700 }}>green</span> zone of Eindhoven – up to 29 minutes. Delivery to
          the <span style={{ color: "#34B4E1", fontWeight: 700 }}>blue</span>. For each zone, we clearly define the time
          of arrival of the courier, and in case of delay, you receive a pleasant surprise, which we will talk about
          later.
          <br/>
          <br/>
          Delivery to the <span style={{ color: "#309300", fontWeight: 700 }}>green</span> zone of Eindhoven – up to 29
          minutes. Delivery to the <span style={{ color: "#F7C200", fontWeight: 700 }}>yellow</span> zone – up to 59
          minutes. Delivery to the <span style={{ color: "#309300", fontWeight: 700 }}>green</span> zone of Eindhoven –
          up
          to 29 minutes. Delivery to the <span style={{ color: "#34B4E1", fontWeight: 700 }}>blue</span> zone – up to 89
          minutes. We value your time very much, so we always try to keep to the minimum time and measure time in
          minutes, because every minute is important. Agree, it’s nice to have a delicious, hot, and fragrant pizza for
          59 minutes, right?
          <br/>
          <br/>
          Orders are previously delivery plus or minus 15 minutes from the set time. For example, if you ordered
          delivery at 12:00, then the courier can deliver
          the order in the interval 11:45 – 12:15.
          <br/>
          <br/>
          If the courier is late, you will receive not only an apology but also a promo code for a free pizza with the
          next order!
          <br/>
          <br/>
          Delivery of alcoholic beverages is carried out from 12:00 AM to 08:45 PM and only to persons who are at least
          18 years old at the time of ordering.
          Only online payment is available for alcoholic beverages.
        </p>
      </div>
    </>
  );
};
