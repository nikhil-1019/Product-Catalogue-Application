# Practical 6 — Product Catalog Application (ASP.NET Core MVC)

This project implements the Product Catalog practical from the supplied lab manual:
- MVC Model (`Models/Product.cs`)
- Controller and routing (`Controllers/ProductDetailsController.cs`)
- Product listing and product details views
- Responsive CSS styling
- Four sample products; no database is required

## Requirements
- .NET 8 SDK
- Internet connection for the remote product images (optional; product text still works without them)

## Run on macOS
1. Extract the ZIP.
2. Open Terminal and `cd` into the `ProductCatalog_PR6` folder.
3. Run:
   ```bash
   dotnet restore
   dotnet run
   ```
4. Open the local URL printed in Terminal (usually `http://localhost:5xxx` or `https://localhost:7xxx`).

## Notes
- The source manual uses classic ASP.NET MVC (`System.Web.Mvc`), which does not run natively on modern macOS. This ZIP uses ASP.NET Core MVC so it can be run with the .NET SDK on macOS.
- The sample product list is stored in memory in the controller, so no database setup is needed.
