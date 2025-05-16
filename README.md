# DynamicPaymentSystem

This is a C# Windows Forms application demonstrating how to dynamically select and execute different payment methods at runtime using **interfaces** and **reflection**.

## Project Overview

The application allows the user to:
- Enter a payment amount.
- Select a payment method from a dropdown list (populated at runtime).
- Execute the selected payment method dynamically.

Each payment method implements a common interface, making the system easily extensible.

## Technologies Used

- C# (.NET Framework / .NET Core)
- Windows Forms (WinForms)
- Reflection
- Interfaces (Polymorphism)

## Project Structure


## How to Run

1. Open the solution in Visual Studio.
2. Build the project.
3. Run the application.
4. Enter an amount and select a payment method to test it.

## Adding New Payment Methods

To add a new payment method:
1. Create a new class that implements `IOdemeYontemi`.
2. Implement the `string Ode(decimal tutar)` method.
3. Rebuild and run the project — the new class will automatically appear in the dropdown.

csharp
public class HavaleOdeme : IOdemeYontemi
{
    public string Ode(decimal tutar)
    {
        return $"Havale ile ödeme yapıldı: {tutar}₺";
    }
}
This project was created for educational purposes to demonstrate:
Use of interfaces and runtime polymorphism.
How to utilize reflection to discover and instantiate types dynamically.
