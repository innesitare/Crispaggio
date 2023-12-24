import Accordion from 'react-bootstrap/Accordion';

import './AccountCard.scss';

export const AccountCard = () => {
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
                  <Accordion.Item eventKey="0">
                    <Accordion.Header>Orders history</Accordion.Header>
                    <Accordion.Body>
                      <div className="custom-accordion-body">
                        <div className="row row-margin">
                          <div className="col-md-3 col-12 d-flex">
                            <p className="row-column-order-id">23708</p>
                          </div>
                          <div className="col-md-2 col-12">
                            <p className="row-column-order-date">19:55 06/11/2023</p>
                          </div>
                          <div className="col-md-2 col-12">
                            <p className="row-column-order-price">30,99 EUR</p>
                          </div>
                          <div className="col-md-3 col-12">
                            <p className="row-column-order-address">Tweelingenlaan 62, Eindhoven</p>
                          </div>
                          <div className="col-md-2 col-12"></div>
                          <hr className="d-lg-none d-md-none d-block"/>
                        </div>
                      </div>
                      <hr className="d-lg-block d-md-block d-none"/>
                      <div className="custom-accordion-body">
                        <div className="row row-margin">
                          <div className="col-md-3 col-12 d-flex">
                            <p className="row-column-order-id">23708</p>
                          </div>
                          <div className="col-md-2 col-12">
                            <p className="row-column-order-date">19:55 06/11/2023</p>
                          </div>
                          <div className="col-md-2 col-12">
                            <p className="row-column-order-price">30,99 EUR</p>
                          </div>
                          <div className="col-md-3 col-12">
                            <p className="row-column-order-address">Tweelingenlaan 62, Eindhoven</p>
                          </div>
                          <div className="col-md-2 col-12"></div>
                          <hr className="d-lg-none d-md-none d-block"/>
                        </div>
                      </div>
                    </Accordion.Body>
                  </Accordion.Item>
                  <Accordion.Item eventKey="1">
                    <Accordion.Header>Personal Data</Accordion.Header>
                    <Accordion.Body>
                      <div className="row mx-3">
                        <div className="col-md-12">
                          <input type="text" className="form-control form-input" placeholder=""/>
                        </div>
                      </div>
                      <div className="row mx-3 my-3">
                        <div className="col-md-12">
                          <input type="text" className="form-control form-input" placeholder=""/>
                        </div>
                      </div>
                      <div className="row mx-3">
                        <div className="col-md-12">
                          <input type="text" className="form-control form-input" placeholder=""/>
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
                  <Accordion.Item eventKey="2">
                    <Accordion.Header>Delivery Addresses</Accordion.Header>
                    <Accordion.Body>
                      <div className="row mx-3">
                        <div className="col-md-12">
                          <input type="text" className="form-control form-input" placeholder=""/>
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
                  <Accordion.Item eventKey="3">
                    <Accordion.Header>Referral link<br/>and promotional code</Accordion.Header>
                    <Accordion.Body>
                    </Accordion.Body>
                  </Accordion.Item>
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
