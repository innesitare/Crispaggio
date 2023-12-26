import { DeliveryAddress } from "./DeliveryAddress";
import { OrderStatus } from "./OrderStatus";
import { OrderItem } from "./OrderItem";

export type Order = {
  id: string;
  orderStatus: OrderStatus;
  deliveryAddress: DeliveryAddress;
  orderItems: OrderItem[];
}