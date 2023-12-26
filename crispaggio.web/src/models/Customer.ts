import { Order } from "./Order";
import { DeliveryAddress } from "./DeliveryAddress";

export type Customer = {
  id: string;
  partyGroupId?: string;
  username: string;
  email: string;
  photoUrl: string;
  loyaltyPoints: number;
  friends?: Customer[];
  deliveryAddresses?: DeliveryAddress[];
  orders?: Order[];
}