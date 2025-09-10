# E-commerce-Payment-Processing 🛒💳

A C# console application implementing an online store with the Factory Method Design Pattern for flexible payment processing.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Design Pattern](#design-pattern)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the Application](#running-the-application)
- [Usage](#usage)
- [Sample Output](#sample-output)
- [File Formats](#file-formats)
- [License](#license)

## Overview

This C# console application implements a complete online store experience using the Factory Method Design Pattern for payment processing. The application reads product data from JSON files, provides an interactive shopping interface, processes payments through multiple methods, and saves order records in both JSON and CSV formats.

## Features

✅ **Product Catalog Management**
- Loads products from `products_json.json`
- Displays product details (ID, name, price, category, description, stock)
- Real-time stock validation

✅ **Factory Method Design Pattern**
- Flexible payment processor creation
- Support for Credit Card, Digital Wallet, and PayPal
- Easy extensibility for new payment methods

✅ **Interactive Console Interface**
- User-friendly product display
- Input validation and error handling
- Order confirmation and receipt generation

✅ **Multiple Export Formats**
- JSON order export using System.Text.Json
- CSV order export using CsvHelper library
- Runtime format selection

✅ **Order Management**
- Complete order tracking with timestamps
- Unique order ID generation
- Detailed order confirmations

## Technologies Used

- **Framework:** .NET 8.0
- **Language:** C#
- **JSON Processing:** System.Text.Json
- **CSV Processing:** CsvHelper NuGet Package
- **Design Pattern:** Factory Method

## Project Structure

```
E-commerce-Payment-Processing/
├── Models/
│   ├── Product.cs
│   ├── Order.cs
│   └── PaymentMethod.cs (enum)
├── Payment/
│   ├──  PaymentProcessor.cs
│   ├── CreditCardProcessor.cs
│   ├── DigitalWalletProcessor.cs
│   ├── PayPalProcessor.cs
│   └── PaymentProcessorFactory.cs
|   └── paymnetMethod.cs
├── Utilities/
│   ├── InputValidator.cs
│   ├── ConsoleInterface.cs
│   └── OrderManager.cs
├── Program.cs
├── products_json.json
├── orders.json
├── orders.csv
├── OnlineStore.csproj
└── README.md
```

## Design Pattern

The application implements the **Factory Method Design Pattern** for payment processing:

- **Interface:** `IPaymentProcessor` defines the payment contract
- **Concrete Processors:** Handle specific payment methods (Credit Card, Digital Wallet, PayPal)
- **Abstract Factory:** Specifies processor creation method
- **Concrete Factories:** Instantiate appropriate processors based on payment method selection

This design ensures loose coupling and makes adding new payment methods straightforward.

## Getting Started

### Prerequisites

- .NET SDK 8.0 or higher
- IDE supporting C# (Visual Studio 2022, Rider, VS Code)
- Git (for cloning the repository)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/E-commerce-Payment-Processing.git
   cd E-commerce-Payment-Processing
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

### Running the Application

Execute the following command in the project directory:

```bash
dotnet run
```

## Usage

The application follows this workflow:

1. **Product Display:** Browse available products with detailed information
2. **Product Selection:** Enter product ID and desired quantity
3. **Payment Processing:** Choose from available payment methods
4. **Order Confirmation:** Review order details and total cost
5. **Export Options:** Save order in JSON or CSV format

## Sample Output

```
Welcome to E-commerce Payment Processing System!
=================================================

Available Products:
+----+------------------+--------+------------+
| ID | Name             | Price  | 
+----+------------------+--------+------------+
| 1  | Gaming Laptop    | $1299  |  
| 2  | Wireless Mouse   | $25    |  
+----+------------------+--------+------------+

Enter Product ID: 1
Enter Quantity: 1
Select Payment Method (CreditCard/DigitalWallet/PayPal): CreditCard

Order Confirmation:
- Product: Gaming Laptop
- Quantity: 1
- Total: $1299
- Payment: Credit Card
- Order ID: ORD-12345

Save format (JSON/CSV): JSON
Order saved successfully!
```

## File Formats

### JSON Output (`orders.json`)
```json
{
  "orderId": "ORD-12345",
  "productId": 1,
  "quantity": 1,
  "totalPrice": 1299.00,
  "paymentMethod": "CreditCard",
  "timestamp": "2024-09-10T14:30:00Z"
}
```

### CSV Output (`orders.csv`)
```csv
OrderId,ProductId,Quantity,TotalPrice,PaymentMethod,Timestamp
ORD-12345,1,1,1299.00,CreditCard,2024-09-10T14:30:00Z
```

 

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

⭐ If you found this project helpful, please give it a star!

📧 For questions or suggestions, please open an issue or contact the maintainers.
