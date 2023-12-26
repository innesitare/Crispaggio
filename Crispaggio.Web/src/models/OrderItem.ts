import { Topic } from "./Topic";

export type OrderItem = {
  id: string;
  title: string;
  description: string;
  price: number;
  rating: number;
  quantity: number;
  topics: Topic[];
}