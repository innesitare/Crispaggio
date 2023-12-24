import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import { OrderCard } from "../components/Cards/OrderCard/OrderCard";

export const Checkout = () => {
  return (
    <>
      <Header/>
      <OrderCard/>
      <Footer/>
    </>
  );
};