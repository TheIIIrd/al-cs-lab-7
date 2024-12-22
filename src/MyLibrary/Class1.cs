[Comment("Класс представляющий пользователя.")]
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

[Comment("Класс представляющий продукт.")]
public class Product
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

[Comment("Класс представляющий заказ.")]
public class Order
{
    public User Customer { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
