
# AspireTemplateSystem

Welcome to **AspireTemplateSystem**, a modular .NET Aspire 9.0 template system designed to facilitate the creation of applications following Clean Architecture principles. This repository contains a structured solution for setting up and managing different aspects of application development, from domain logic to user interface, data access, and more.

## Badges

![.NET](https://github.com/shawn-delaine-bellazan/AspireTemplateSystem/workflows/.NET%20Build%20and%20Test/badge.svg)
[![License: MIT](https://opensource.org/license/mit)

## Table of Contents

- [About](#about)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## About

AspireTemplateSystem aims to provide a reusable template structure for .NET Aspire projects, ensuring separation of concerns, modularity, and ease of maintenance. It includes:

- **Core**: Domain logic, application services, and interfaces.
- **DataAccess**: Data access operations, including database context and repositories.
- **UserInterface**: Presentation layer, currently reserved for future UI integrations.
- **Utilities**: Shared utility classes and functions.
- **SharedConfig**: Centralized configuration management.
- **AppHost**: The main entry point for the application, integrating all parts.
- **ApiService**: Placeholder for API services.

## Project Structure

The solution is divided into several projects, each serving a specific purpose:

```
AspireTemplateSystem/
├── AspireTemplateSystem.ApiService/
├── AspireTemplateSystem.AppHost/
├── AspireTemplateSystem.Core/
│   ├── Application/
│   │   ├── Interfaces/
│   │   ├── Services/
│   │   └── UnitOfWork/
│   ├── Common/
│   ├── Domain/
│   │   ├── Entities/
│   │   └── ValueObjects/
│   ├── Exceptions/
│   └── GlobalUsings.cs
├── AspireTemplateSystem.DataAccess/
│   ├── Configurations/
│   ├── Database/
│   ├── Entities/
│   ├── Migrations/
│   └── Repositories/
├── AspireTemplateSystem.SharedConfig/
├── AspireTemplateSystem.UserInterface/
└── AspireTemplateSystem.Utilities/
```

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet) or later
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) with C# support
- [Git](https://git-scm.com/)

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/shawn-delaine-bellazan/AspireTemplateSystem.git
   ```

2. **Navigate to the Project Directory**:
   ```bash
   cd AspireTemplateSystem
   ```

3. **Restore NuGet Packages**:
   Open the solution in Visual Studio or run:
   ```bash
   dotnet restore
   ```

4. **Build the Solution**:
   ```bash
   dotnet build
   ```

## Usage

### Running the Application

Start with the AspireTemplateSystem.AppHost project, which serves as the entry point for the application. You can run it directly from Visual Studio or use:
```bash
dotnet run --project AspireTemplateSystem.AppHost
```

### Developing New Features

Use the structured projects to add new domain entities, services, repositories, or UI components as needed. Follow the existing patterns for consistency.

## Contributing

Contributions are welcome! Here's how you can contribute:

1. Fork the repository and create your branch from `main`.
2. Implement your feature or fix bugs in your branch.
3. Test your changes thoroughly.
4. Submit a pull request with a clear description of what you've changed.

Please ensure your code adheres to the project's coding standards and passes all tests.

## License

This project is licensed under the MIT License (LICENSE). Feel free to use and modify this template for your own projects.

If you find any issues or have suggestions for improvements, please open an issue or submit a pull request. Thank you for your interest in AspireTemplateSystem!
