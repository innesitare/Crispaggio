import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import { InformationCard } from "../components/Cards/InformationCard/InformationCard";

export const Information = () => {
  return (
    <>
      <Header/>
      <InformationCard/>
      <Footer/>
    </>
  );
};