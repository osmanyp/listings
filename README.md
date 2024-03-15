# Full Stack Angular/.NET Core Project

This repository hosts a full-stack application featuring an Angular 17 Single Page Application (SPA) within the `spa` folder, and a .NET Core 8 API within the `api` folder. The API employs Entity Framework Core 8 with an in-memory database and adheres to clean architecture principles. It leverages AutoMapper for efficient object mapping and inversion of control for better dependency management.

## Getting Started

To clone and run this project locally, follow these instructions.

### Prerequisites

- Node.js (for Angular)
- .NET Core 8 SDK
- Angular CLI version 17

### Installation

Clone the repository:

```bash
git clone https://github.com/osmanyp/listings.git
cd fullstack-project

Front-end Setup
To set up and start the Angular application:

cd spa
npm install
ng serve


Visit http://localhost:4200/ to view the app.

Back-end Setup
To set up and run the .NET Core API:

cd api
dotnet restore
dotnet run


The API will be accessible at https://localhost:5001/.

Front-end: Angular SPA
Model
The SPA manages listings based on the following model:



export interface Listing {
    id: number;
    price: number;
    bathrooms: number;
    halfBathrooms: number;
    bedrooms: number;
    yearBuilt: number;
    address: string;
    photoUrl: string;
}

CRUD Operations
The Angular service communicates with the backend API to perform CRUD operations.

Back-end: .NET Core API
Clean Architecture Benefits
Clean Architecture emphasizes separation of concerns, improving maintainability, flexibility, and development efficiency by:

Independent Development: Enables separate development on business logic and UI/database concerns.
Testability: Facilitates unit testing of business logic.
Framework Independence: Business logic remains independent of the framework, easing framework updates or changes.
Database Agnosticism: The architecture supports switching between different types of databases with minimal changes.
UI Agnosticism: Allows for changes in the UI without affecting business logic.
AutoMapper Benefits
AutoMapper streamlines object mapping, enhancing developer productivity and code maintainability by:

Reduced Boilerplate Code: Minimizes repetitive code for object-to-object mappings.
Improved Productivity: Focus more on business logic rather than data transfer object mappings.
Consistency: Ensures consistent mappings throughout the application.
Flexibility: Provides custom configurations for complex mapping scenarios.
Maintainability: Simplifies maintenance by reducing manual mapping code.
Architecture Overview
The API is structured into several layers, adhering to clean architecture principles:

Domain: Contains the business logic and entities.
Application: Hosts interfaces and services defining application logic.
Infrastructure: Includes data access layer, repositories, and other infrastructure concerns.
API: The entry point of the application, containing controllers.

Authors
Your Osmany Perez Feria