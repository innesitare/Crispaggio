import React from "react";

import { Header } from "../components/Header/Header";
import { PromotionsCarousel } from "../components/Carousel/PromotionsCarousel";
import { DescriptionBanner } from "../components/DescriptionBanner/DescriptionBanner";
import { SaladsComponent } from "../components/Cards/Salads/SaladsComponent";
import { FrequentlyAskedQuestions } from "../components/FrequentlyAskedQuestions/FrequentlyAskedQuestions";
import { Footer } from "../components/Footer/Footer";

export const Salads = () => {
  return (
    <>
      <Header/>
      <PromotionsCarousel/>
      <SaladsComponent/>
      <DescriptionBanner/>
      <FrequentlyAskedQuestions/>
      <Footer/>
    </>
  );
};