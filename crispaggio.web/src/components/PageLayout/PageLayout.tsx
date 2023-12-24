import React from 'react';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Checkout } from "../../pages/Checkout";
import { Information } from "../../pages/Information";
import { Account } from "../../pages/Account";

export const PageLayout: React.FC = () => {
  return (
    <>
      <Router>
        <Routes>
          <Route path="/information" element={<Information/>}/>
          <Route path="/checkout" element={<Checkout/>}/>
          <Route path="/personal-account" element={<Account/>}/>
        </Routes>
      </Router>
    </>
  );
}