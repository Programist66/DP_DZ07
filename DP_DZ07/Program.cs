using DZ_DP07;

Purchases products = new Purchases();
products.Add("тетрадь");
products.Add("карандаш");
products.Add("ручка");

foreach (var item in products)
{
    Console.WriteLine(item);
}
