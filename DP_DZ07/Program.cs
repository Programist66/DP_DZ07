using DZ_DP07;

//Product product3 = new Product("Карандаш", null);
//Product product2 = new Product("Ручка", product3);
//Product product1 = new Product("Тетрадь", product2);

//Purchases products = new Purchases(product1);

Purchases products = new Purchases();
products.Insert("тетрадь");
products.Insert("ручка");
products.Insert("карандаш");



foreach (var item in products)
{
    Console.WriteLine(item);
}
