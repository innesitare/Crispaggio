import React from 'react';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import { Home } from "../../pages/Home";
import { Sushi } from "../../pages/Sushi";
import { Salads } from "../../pages/Salads";
import { Checkout } from "../../pages/Checkout";
import { DeliveryInformation } from "../../pages/DeliveryInformation";
import { Account } from "../../pages/Account";

export const PageLayout: React.FC = () => {
  return (
    <>
      <Router>
        <Routes>
          <Route path="/" element={<Home/>}/>
          <Route path="/sushi" element={<Sushi/>}/>
          <Route path="/salads" element={<Salads/>}/>

          <Route path="/delivery" element={<DeliveryInformation/>}/>
          <Route path="/checkout" element={<Checkout/>}/>
          <Route path="/personal-account" element={<Account/>}/>
        </Routes>
      </Router>
    </>
  );
}