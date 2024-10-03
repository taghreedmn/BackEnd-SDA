# Video Games Store

## Overview
This repository contains screenshots of the Entity Relationship Diagram (ERD) and the Relational Database Schema (RDS) for **Video Games Store**. The ERD provides a high-level overview of the relationships between different entities in the system, while the RDS offers a detailed view of the tables and their attributes.

## Table of Contents
- [Introduction](#introduction)
- [Entity Relationship Diagram (ERD)](#entity-relationship-diagram-erd)
- [Relational Database Schema (RDS)](#relational-database-schema-rds)

## Introduction
In database design, the ERD and RDS serve complementary roles. The ERD focuses on the relationships and interactions between entities, allowing for a conceptual understanding of the data model. Conversely, the RDS details how this model is implemented in a relational database, specifying the tables, columns, data types, and relationships.

## Entity Relationship Diagram (ERD)
![Entity Relationship Diagram](Team5_FusionTech_ERD.svg)
**Description:** The ERD visualizes the entities involved in the system and their relationships. Each entity represents a distinct object or an actor in the system 

### Entities and Attributes

#### Game Studio
**Description:** A Studio that develops and produces video games, responsible for the creative and technical aspects of game development.
- Studio_ID: Unique identifier for the studio
- Studio_Name: Name of the game studio
- Studio_Picture_Path : The path of studio's picture 

#### Publisher
**Description:** A company that finances and distributes video games.
- Publisher_ID: Unique identifier for the publisher
- Publisher_Name: Name of the publishing company
- Email: Contact details for the publisher
- Publisher_Picture_Path : The path of publisher's picture 

#### Video Game
**Description:** An interactive digital entertainment product that can be played on various platforms, including but not limited to video game consoles, PCs, and mobile devices.
- Game_ID: Unique identifier for the video game
- Name: Name of the video game
- Year_of_Release: Date when the game was released
- Price: Price of the Game
- Game_Picture_Path : The path of Game's picture 

#### Video Game Version
**Description:** Represents a specific  edition of a video game. Each version may have distinct console, price, or changes compared to other versions of the same game.
- GameVersion_ID :Unique identifier for the video Version
- Price: Price of the Game 



#### Order
**Description:** A transaction record that captures the details of a purchase made by a customer, including the items bought, quantities, and payment information.
- Order_Id: Unique identifier for the order
- Order_date: Date when the order was placed
- Total_Price: Total cost of the order



#### Supplier
**Description:** A business entity that provides products, such as video games or gaming accessories, to retailers or distributors.
- Supplier_ID: Unique identifier for the supplier
- Supplier_Name: Name of the supplier
- Supplier_Contact_info: Contact details for the supplier
- Supplier_Bank_info: Bank details for the supplier

#### Category
**Description:** A classification that groups similar products together, facilitating easier navigation and organization within a store or inventory system (e.g., action games, adventure games).
- Category_ID: Unique identifier for the category
- Category_Name: Name of the category

#### Console
**Description:** A hardware device specifically designed for playing video games, such as PlayStation, Xbox, or Nintendo Switch.
- Console_ID: Unique identifier for the console
- Console_Name: Name of the console


#### Inventory
**Description:** A record of available products within a store or warehouse, including quantities, types, and statuses of items.
- Inventory_ID: Unique identifier for the inventory record



#### Store
**Description:** A retail establishment that sells video games, consoles, and accessories, either physically or online.
- Store_ID: Unique identifier for the store
- Store_Name: Name of the store
- Location: Physical address of the store
- Number_of_employee: Number of how many employees in the store

#### Payment
**Description:** The process of transferring money in exchange for goods or services, including various methods like credit cards, digital wallets, or cash.
- payment_id: Unique identifier for the payment
- payment_method: Method used for payment (e.g., credit card, PayPal)


#### Store Employee
**Description:** An individual employed by a store to assist customers, manage sales, and maintain inventory.
- Employee_work_hours: Number of employee's working hours
- Role : role of Employee in the store 
- Salary : salary of the employee 
- Years_of_Service : Years of service of employee in the store 


#### Person
**Description:** A general entity representing an individual, which can be a customer or employee.
- person_id: Unique identifier for the person
- person_name: Full name of the person
- person_email: Email address of the person
- person_phone: Phone number of the person
- profile_Picture_Path : The path of person's profile picture 

#### System admin
**Description:** An entity representing the privileges or managing responsibilities a system admin has .
- Manage_Stores: privileges to manage the stores in the system  
- Manage_Employees: privileges to manage the employees in the system  
- Manage_Games: privileges to manage the games in the system  
- Manage_Customers: privileges to manage the customers in the system 


## Relational Database Schema (RDS)
![Relational Database Schema](Team5_FusionTech_RDS.svg)
**Description:** The RDS provides a detailed breakdown of the database structure, including tables, attributes, and data types. This schema is essential for understanding how to implement the ERD in a relational database.

### Relationships
- **Developed By:** Relates game studios to the games they develop.
- **Played In:** Relates games to the consoles they can be played on.
- **VideoGame_Category:** Associates games with their genre categories.
- **Rated By:** Stores user ratings for individual games.
- **Published By:** Relates games to their publishing companies.
- **Supply:** Tracks the supply of games from suppliers to stores.
- **Ordered Games:** Stores information about games ordered by customers.
