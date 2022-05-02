namespace PizzaProject
{
    //todo: paymenthandler logic
    class PaymentHandler
    {
        //verifies credit card data and charges the customer's card
        void ProcessPayment()
        {
            //do not implement this. outside the scope of the project, but the method is required.
        }

        //methods for calculating price of order
        public decimal CalculateOrderTotal(Order o)
        {
            decimal total = 0;
            total = CalculateSubtotalOfOrder(o);
            total = total + CalculateTax(total);
            return total;
        }
        public decimal CalculateTax(decimal subtotal)
        {
            decimal total = subtotal * .07M;
            return total;
        }
        public decimal CalculateSubtotalOfOrder(Order o)
        {
            decimal subtotal = 0;
            foreach(Item i in o.Items)
            {
                subtotal += CalculatePriceOfItem(i);
            }
            return subtotal;
        }

        //very messy price implementation; lots of ways to implement this better. alas.
        public decimal CalculatePriceOfItem(Item i)
        {
            decimal price = 0;

            if (i.ItemType == "Pizza")
            {
                price += i.Toppings.Count * .5M;

                if (i.Size == "12\"")
                {
                    price += 7.00M;
                }
                else if (i.Size == "16\"")
                {
                    price += 10.00M;
                }
                else if (i.Size == "18\"")
                {
                    price += 12.25M;
                }

                if (i.CrustType == "Hand Tossed")
                {
                    price += 3M;
                }
                else if (i.CrustType == "Deep Dish")
                {
                    price += 5M;
                }
                else if (i.CrustType == "Thin Crust")
                {
                    price += 1M;
                }
                return price;
            }
            else if (i.ItemType == "Soda")
            {
                if (i.Flavor == "Water")
                {
                    price += 0M;
                }
                else
                {
                    if (i.Size == "Small")
                    {
                        price += 1.5M;
                    }
                    else if (i.Size == "Medium")
                    {
                        price += 2M;
                    }
                    else if (i.Size == "Large")
                    {
                        price += 2.3M;
                    }
                    else if (i.Size == "2-Liter")
                    {
                        price += 4.1M;
                    }

                }
            }
            return price;
        }
    }
}