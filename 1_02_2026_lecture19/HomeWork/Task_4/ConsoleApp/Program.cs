//## Home Task 4: Product
//- `name` (string): The name of the product.
//- `price` (double): The price of the product.
//- `quantity` (int): The quantity of the product.
//#### Constructor
//The `Product` class has a constructor that takes three parameters:
//- `name` (string): The name of the product.
//- `price` (double): The price of the product.
//- `quantity` (int): The quantity of the product.
//#### Method
//The `Product` class has a method called `PrintProduct()` that prints the product information in the following format:
//В классе Product есть метод PrintProduct(), который печатает информацию о продукте в следующем формате:
//Синфи "Маҳсулот" дорои усули "PrintProduct()" мебошад, ки маълумоти маҳсулотро дар формати зерин чоп мекунад:
//```
//{ name}: price {price}: { quantity}
//pcs
//```
//For example, if the product is assigned the name "Banana", with a price of 1.1 and a quantity of 13, the output would be:
//Например, если продукту присвоено имя «Банан», цена 1,1 и количество 13, результат будет следующим:
//Масалан, агар ба маҳсулот номи "Банан" дода шавад, ки нархи он 1,1 ва миқдори 13 аст, натиҷа чунин хоҳад буд:
//```
//Banana: price 1.1: 13 pcs
//```

using Infrastructure.Services;

ProductServices productService1 = new ProductServices("Banan", 5.5, 20);
ProductServices productService2 = new ProductServices("Lemon", 4, 25);

productService1.PrintProduct();
productService2.PrintProduct();