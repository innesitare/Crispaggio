import React from "react";

import { Header } from "../components/Header/Header";
import { PromotionsCarousel } from "../components/Carousel/PromotionsCarousel";
import { DescriptionBanner } from "../components/DescriptionBanner/DescriptionBanner";
import { SushiComponent } from "../components/Cards/Sushi/SushiComponent";
import { FrequentlyAskedQuestions } from "../components/FrequentlyAskedQuestions/FrequentlyAskedQuestions";
import { Footer } from "../components/Footer/Footer";

export const Sushi = () => {
  return (
    <>
      <Header/>
      <PromotionsCarousel/>
      <SushiComponent/>
      <DescriptionBanner/>
      <FrequentlyAskedQuestions/>
      <Footer/>
    </>
  );
};