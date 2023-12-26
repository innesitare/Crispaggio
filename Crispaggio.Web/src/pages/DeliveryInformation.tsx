import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import { DeliveryInformationComponent } from "../components/DeliveryInformation/DeliveryInformationComponent";

export const DeliveryInformation = () => {
  return (
    <>
      <Header/>
      <DeliveryInformationComponent/>
      <Footer/>
    </>
  );
};