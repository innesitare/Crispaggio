import React from "react";
import Accordion from "react-bootstrap/Accordion";
import { Customer } from "../../../../models/Customer";

type PersonalDataContentProps = {
  customer: Customer | undefined;
}

export const PersonalDataContent: React.FC<PersonalDataContentProps> = ({ customer }) => {
  return (
    <React.Fragment>
      <Accordion.Item eventKey="1">
        <Accordion.Header>Personal Data</Accordion.Header>
        <Accordion.Body>
          <div className="row mx-3">
            <div className="col-md-12">
              <input type="text" className="form-control form-input" placeholder={customer?.username}/>
            </div>
          </div>
          <div className="row mx-3 my-3">
            <div className="col-md-12">
              <input type="text" className="form-control form-input" placeholder={customer?.email}/>
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