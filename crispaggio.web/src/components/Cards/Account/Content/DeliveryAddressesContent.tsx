import React from "react";
import Accordion from "react-bootstrap/Accordion";
import { DeliveryAddress } from "../../../../models/DeliveryAddress";

type DeliveryAddressesContentProps = {
  deliveryAddress: DeliveryAddress | undefined;
}

export const DeliveryAddressesContent: React.FC<DeliveryAddressesContentProps> = ({ deliveryAddress }) => {
  return (
    <React.Fragment>
      <Accordion.Item eventKey="2">
        <Accordion.Header>Delivery Addresses</Accordion.Header>
        <Accordion.Body>
          <div className="row mx-3">
            <div className="col-md-12">
              <input type="text" className="form-control form-input" placeholder={deliveryAddress?.id}/>
            </div>
          </div>
          <div className="row mx-3">
            <div className="col-md-12">
              <button className="general-button">Save</button>
              <button className="general-button general-button-left">Cancel</button>
            </div>
          </div>
        </Accordion.Body>
      </Accordion.Item>
    </React.Fragment>
  );
}