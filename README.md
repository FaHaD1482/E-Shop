# Shopping Application

This C# based Shopping application is designed for three types of users: Owner, Employee, and Customers. The application uses MySQL as the database and GUNA UI (version: 2.0.4.4) as the UI library, providing a modern and user-friendly interface.

## App Screenshot

<p align="center">
    <img src="Images/1.png" alt="Screenshot-2024-01-02-222621">
    <img src="Images/2.png" alt="Screenshot-2024-01-02-222403">
    <img src="Images/3.png" alt="Screenshot-2024-01-02-222802">
    <img src="Images/4.png" alt="Screenshot-2024-01-02-223016">
    <img src="Images/5.png" alt="Screenshot-2024-01-02-222441">
    <img src="Images/6.png" alt="Screenshot-2024-01-02-223235">
</p>

## Features

- **User Roles:**
  - **Owner:** Manages overall system settings and configurations.
  - **Employee:** Handles day-to-day operations, including managing products and orders.
  - **Customer:** Shops for products, adds items to the cart, and places orders.

- **Database:**
  - The application utilizes MySQL to store and manage user data, product information, orders, and more.

- **User Interface:**
  - GUNA UI (version: 2.0.4.4) is employed to create a sleek and modern user interface for a pleasant user experience.

## Getting Started

**Database Setup**
* Import the provided SQL schema file.
* File name: **E-Shop.bacpac**

**Open in Visual Studio**
* Open the solution file in Visual Studio.

**Configure Database Connection**
* Update the database connection string in the code to match your MySQL server configuration.
* Copy your connection string and replace it with "Your connection string" on "E-Shop/Database/DatabaseConnection.cs" file.

**Build and Run**
* Build and run the application.

## User Roles and Functionality
* #### Owner
Manages system-wide settings and configurations.
Accesses administrative features.
* #### Employee
Manages products, categories, and processes orders.
Handles day-to-day operations.
* #### Customer
Browses products, adds items to the cart, and places orders.
Enjoys a seamless shopping experience.

## Dependencies
* **GUNA UI - Version 2.0.4.4**
## Important
* **Note:** You don't have to install it, but if you hove got resolution or any other screen/icon issue, just install VictorMono, DankMono, JuliaMono, HackFont, RobotoFont, also you can set the resolution scale 150% and in 1080p resoltion it will provide accurate result because the application is not responsive.
