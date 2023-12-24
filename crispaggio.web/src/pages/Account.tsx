import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import { AccountCard } from "../components/Cards/AccountCard/AccountCard";

export const Account = () => {
  return (
    <>
      <Header/>
      <AccountCard/>
      <Footer/>
    </>
  );
};