import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import { OrderComponent } from "../components/Cards/Order/OrderComponent";

export const Checkout = () => {
  return (
    <>
      <Header/>
      <OrderComponent/>
      <Footer/>
    </>
  );
};