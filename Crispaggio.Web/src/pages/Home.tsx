import React from "react";
import { Header } from "../components/Header/Header";
import { PromotionsCarousel } from "../components/Carousel/PromotionsCarousel";
import { HomeComponent } from "../components/Cards/Home/HomeComponent";
import { DescriptionBanner } from "../components/DescriptionBanner/DescriptionBanner";
import { FrequentlyAskedQuestions } from "../components/FrequentlyAskedQuestions/FrequentlyAskedQuestions";
import { Footer } from "../components/Footer/Footer";

export const Home = () => {
  return (
    <>
      <Header/>
      <PromotionsCarousel/>
      <HomeComponent/>
      <DescriptionBanner/>
      <FrequentlyAskedQuestions/>
      <Footer/>
    </>
  );
};