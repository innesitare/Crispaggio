import React from "react";

import "./FrequentlyAskedQuestions.scss";

export const FrequentlyAskedQuestions = () => {
  return (
    <>
      <div className="container-fluid mt-3 pb-5" style={{ backgroundColor: "#FAFAFA" }}>
        <div className="container">
          <div className="row">
            <div className="col-md-12">
              <p className="faq-header my-5">Frequently Asked Questions</p>
            </div>
            <div className="row">
              <div className="col-md-2"></div>
              <div className="col-md-8">
                <div className="accordion" id="accordionExample">
                  <div className="accordion-item">
                    <h2 className="accordion-header">
                      <button
                        className="accordion-button collapsed pb-0 pt-0"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseOne"
                        aria-expanded="false"
                        aria-controls="collapseOne"
                      >
                        <p className="faq-paragraph mb-0">💰 Is delivery free?</p>
                      </button>
                    </h2>
                    <div
                      id="collapseOne"
                      className="accordion-collapse collapse"
                      data-bs-parent="#accordionExample"
                    >
                      <div className="accordion-body">
                        <strong>This is the second item's accordion body.</strong> It is hidden
                        by default, until the collapse plugin adds the appropriate classes that
                        we use to style each element. These classes control the overall
                        appearance, as well as the showing and hiding via CSS transitions. You
                        can modify any of this with custom CSS or overriding our default
                        variables. It's also worth noting that just about any HTML can go within
                        the <code>.accordion-body</code>, though the transition does limit
                        overflow.
                      </div>
                    </div>
                  </div>
                  <hr/>
                  <div className="accordion-item">
                    <h2 className="accordion-header">
                      <button
                        className="accordion-button collapsed pb-0 pt-0"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseTwo"
                        aria-expanded="false"
                        aria-controls="collapseTwo"
                      >
                        <p className="faq-paragraph mb-0">💳 Is it possible to pay by card?</p>
                      </button>
                    </h2>
                    <div
                      id="collapseTwo"
                      className="accordion-collapse collapse"
                      data-bs-parent="#accordionExample"
                    >
                      <div className="accordion-body">
                        <strong>This is the second item's accordion body.</strong> It is hidden
                        by default, until the collapse plugin adds the appropriate classes that
                        we use to style each element. These classes control the overall
                        appearance, as well as the showing and hiding via CSS transitions. You
                        can modify any of this with custom CSS or overriding our default
                        variables. It's also worth noting that just about any HTML can go within
                        the <code>.accordion-body</code>, though the transition does limit
                        overflow.
                      </div>
                    </div>
                  </div>
                  <hr/>
                  <div className="accordion-item">
                    <h2 className="accordion-header">
                      <button
                        className="accordion-button collapsed pb-0 pt-0"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseThree"
                        aria-expanded="false"
                        aria-controls="collapseThree"
                      >
                        <p className="faq-paragraph mb-0">🚀 How long to wait for delivery?</p>
                      </button>
                    </h2>
                    <div
                      id="collapseThree"
                      className="accordion-collapse collapse"
                      data-bs-parent="#accordionExample"
                    >
                      <div className="accordion-body">
                        <strong>This is the second item's accordion body.</strong> It is hidden
                        by default, until the collapse plugin adds the appropriate classes that
                        we use to style each element. These classes control the overall
                        appearance, as well as the showing and hiding via CSS transitions. You
                        can modify any of this with custom CSS or overriding our default
                        variables. It's also worth noting that just about any HTML can go within
                        the <code>.accordion-body</code>, though the transition does limit
                        overflow.
                      </div>
                    </div>
                  </div>
                  <hr/>
                  <div className="accordion-item">
                    <h2 className="accordion-header">
                      <button
                        className="accordion-button collapsed pb-0 pt-0"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseFour"
                        aria-expanded="false"
                        aria-controls="collapseFour"
                      >
                        <p className="faq-paragraph mb-0">⏰ What is your work schedule?</p>
                      </button>
                    </h2>
                    <div
                      id="collapseFour"
                      className="accordion-collapse collapse"
                      data-bs-parent="#accordionExample"
                    >
                      <div className="accordion-body">
                        <strong>This is the second item's accordion body.</strong> It is hidden
                        by default, until the collapse plugin adds the appropriate classes that
                        we use to style each element. These classes control the overall
                        appearance, as well as the showing and hiding via CSS transitions. You
                        can modify any of this with custom CSS or overriding our default
                        variables. It's also worth noting that just about any HTML can go within
                        the <code>.accordion-body</code>, though the transition does limit
                        overflow.
                      </div>
                    </div>
                  </div>
                  <hr/>
                  <div className="accordion-item">
                    <h2 className="accordion-header">
                      <button
                        className="accordion-button collapsed pb-0 pt-0"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseFive"
                        aria-expanded="false"
                        aria-controls="collapseFive"
                      >
                        <p className="faq-paragraph mb-0">🍕 In which cities does Crispaggio pizza delivery work?</p>
                      </button>
                    </h2>
                    <div
                      id="collapseFive"
                      className="accordion-collapse collapse"
                      data-bs-parent="#accordionExample"
                    >
                      <div className="accordion-body">
                        <strong>This is the second item's accordion body.</strong> It is hidden
                        by default, until the collapse plugin adds the appropriate classes that
                        we use to style each element. These classes control the overall
                        appearance, as well as the showing and hiding via CSS transitions. You
                        can modify any of this with custom CSS or overriding our default
                        variables. It's also worth noting that just about any HTML can go within
                        the <code>.accordion-body</code>, though the transition does limit
                        overflow.
                      </div>
                    </div>
                  </div>
                  <hr/>
                  <div className="accordion-item">
                    <h2 className="accordion-header">
                      <button
                        className="accordion-button collapsed pb-0 pt-0"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseSix"
                        aria-expanded="false"
                        aria-controls="collapseSix"
                      >
                        <p className="faq-paragraph mb-0">🍴 What other delicious things can i try at your place?</p>
                      </button>
                    </h2>
                    <div
                      id="collapseSix"
                      className="accordion-collapse collapse"
                      data-bs-parent="#accordionExample"
                    >
                      <div className="accordion-body">
                        <strong>This is the second item's accordion body.</strong> It is hidden
                        by default, until the collapse plugin adds the appropriate classes that
                        we use to style each element. These classes control the overall
                        appearance, as well as the showing and hiding via CSS transitions. You
                        can modify any of this with custom CSS or overriding our default
                        variables. It's also worth noting that just about any HTML can go within
                        the <code>.accordion-body</code>, though the transition does limit
                        overflow.
                      </div>
                    </div>
                  </div>
                  <hr/>
                </div>
              </div>
              <div className="col-md-2"></div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};