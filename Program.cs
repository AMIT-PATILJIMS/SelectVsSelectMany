namespace SelectVsSelectMany
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>()
            {
                new Order()
                {
                    OrderID = "101",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine()
                        {
                            ProductSKU = "SKU1",
                            Quantity = 3
                        },
                        new OrderLine()
                        {
                            ProductSKU = "SKU2",
                            Quantity = 2
                        },
                        new OrderLine()
                        {
                            ProductSKU = "SKU3",
                            Quantity = 1
                        }
                    }
                },

                new Order()
                {
                    OrderID = "102",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine()
                        {
                            ProductSKU = "SKU5",
                            Quantity = 3
                        },
                        new OrderLine()
                        {
                            ProductSKU = "SKU8",
                            Quantity = 2
                        },
                        new OrderLine()
                        {
                            ProductSKU = "SKU9",
                            Quantity = 1
                        }
                    }
                }
            };

            //Use Nested for loop for List

            var nestedItems = orders.Select(x => x.OrderLines);

            /*
            foreach (var item in nestedItems)
            {
                foreach (var x in item)
                {
                    Console.WriteLine(x.ProductSKU);
                }
            }
            */

            var nestesItemsWithSelectMany = orders.SelectMany(x => x.OrderLines);

            foreach (var item in nestesItemsWithSelectMany)
            {
                Console.WriteLine(item.ProductSKU);
            }
        }
    }

    public class Order
    {
        public string OrderID { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
    public class OrderLine
    {
        public string ProductSKU { get; set; }
        public int Quantity { get; set; }
    }
    public class OrderLineForReport
    {
        public string OrderID { get; set; }
        public string ProductSKU { get; set; }
        public int Quantity { get; set; }
    }
}