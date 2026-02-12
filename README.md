# Daily Business Summary Calculator (C#)

## Overview

This C# console application calculates key daily business metrics including:

- Revenue
- Profit
- Profit Margin

## Example Output
<img width="320" height="170" alt="Screenshot 2026-02-12 at 3 24 59 AM" src="https://github.com/user-attachments/assets/cbd66d06-551e-4ff1-b717-fb852aae3827" />

The program simulates a simple financial reporting tool that could be used by a small business to quickly summarize daily performance.

This project demonstrates clean input validation, financial calculations using appropriate data types, and formatted business output.

---

## Features

- Calculates total **Revenue** from number of sales and average sale amount
- Calculates **Profit** using total cost
- Computes **Profit Margin**
- Validates user input (non-negative integers and decimals)
- Uses `decimal` data type for financial accuracy
- Formats output as currency and numeric values

---

## Business Logic

The application uses the following formulas:

- **Revenue** = Sales Count × Average Sale
- **Profit** = Revenue − Total Cost
- **Profit Margin** = Profit ÷ Revenue

If revenue is zero, margin safely defaults to 0 to prevent division errors.

---

## Technologies Used

- C#
- .NET Console Application
- System.Globalization (for safe numeric parsing)
- String interpolation
- Currency formatting (`:C`)

---

## How to Run

## Prerequisites
- .NET SDK installed
- Visual Studio or VS Code (optional)

## Run Locally

Clone the repository:

```bash
git clone https://github.com/hanyi139/FinancialCalc.git
cd FinancialCalc


