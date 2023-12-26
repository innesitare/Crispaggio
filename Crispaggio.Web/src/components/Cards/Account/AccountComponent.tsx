import Accordion from 'react-bootstrap/Accordion';

import './AccountComponent.scss';
import { OrdersHistoryContent } from "./Content/OrdersHistoryContent";
import { PersonalDataContent } from "./Content/PersonalDataContent";
import { DeliveryAddressesContent } from "./Content/DeliveryAddressesContent";
import { ReferralsContent } from "./Content/ReferralsContent";

export const AccountComponent = () => {
  return (
    <>
      <div className="container-fluid account-card-background">
        <p className="account-card-header">Personal account</p>
      </div>
      <div className="container mb-5">
        <div className="row">
          <div className="col-md-1"></div>
          <div className="col-md-10 account-card-background-white">
            <div className="row">
              <div className="col-md-12">
                <Accordion>
                  <OrdersHistoryContent orders={undefined}></OrdersHistoryContent>
                  <PersonalDataContent customer={undefined}></PersonalDataContent>
                  <DeliveryAddressesContent deliveryAddress={undefined}></DeliveryAddressesContent>
                  <ReferralsContent></ReferralsContent>
                </Accordion>
              </div>
            </div>
          </div>
        </div>
        <div className="row mt-4 mb-5 pb-5">
          <div className="col-md-1"></div>
          <div className="col-md-10">
            <div className="row general-actions-header">
              <div className="col-md-10 col-7 sub-header">
                <button className="logout-button">Log out</button>
              </div>
              <div className="col-md-2 col-5 delete-account-button-position">
                <button className="delete-account-button">Delete account</button>
              </div>
            </div>
          </div>
          <div className="col-6"></div>
        </div>
      </div>
    </>
  );
}
