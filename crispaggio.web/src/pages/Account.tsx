import React from "react";
import { Header } from "../components/Header/Header";
import { Footer } from "../components/Footer/Footer";
import { AccountComponent } from "../components/Cards/Account/AccountComponent";

export const Account = () => {
  return (
    <>
      <Header/>
      <AccountComponent/>
      <Footer/>
    </>
  );
};