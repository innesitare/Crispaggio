import React from "react";
import Accordion from "react-bootstrap/Accordion";
import { Order } from "../../../../models/Order";

type OrdersHistoryContentProps = {
  orders: Order[] | undefined;
}

export const OrdersHistoryContent: React.FC<OrdersHistoryContentProps> = ({ orders }) => {
  return (
    <React.Fragment>
      {orders?.map(order => (
        <Accordion.Item key={order.id} eventKey="0">
          <Accordion.Header>Order History</Accordion.Header>
          <Accordion.Body>
            <div className="row row-margin">
              <div className="col-md-3 col-12 d-flex">
                <p className="row-column-order-id">{order.id}</p>
              </div>
              <div className="col-md-2 col-12">
                <p className="row-column-order-date">{order.id}</p>
              </div>
              <div className="col-md-2 col-12">
                <p className="row-column-order-price">{order.id} EUR</p>
              </div>
              <div className="col-md-3 col-12">
                <p className="row-column-order-address">{order.id}</p>
              </div>
              <div className="col-md-2 col-12"></div>
              <hr className="d-lg-none d-md-none d-block"/>
            </div>
            <hr className="d-lg-block d-md-block d-none"/>
          </Accordion.Body>
        </Accordion.Item>
      ))}
    </React.Fragment>
  );
};
