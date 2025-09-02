using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_Payment_Proccesing.Service;
public record Product(
int id,
string name,
double price,
string category,
string description,
bool inStock
);

public record Root(
IReadOnlyList<Product> products
);

