# EventFlow.NET

**A scalable and maintainable event-driven application built with ASP.NET 8**

EventFlow.NET is an event-driven application designed to streamline event management and simplify complex workflows. This project prioritizes loose coupling and clean architecture principles to ensure a well-structured and adaptable codebase.

**Key Features:**

* **Domain-Driven Design (DDD):**  EventFlow.NET adheres to DDD principles, separating core functionalities from infrastructure concerns. This promotes cleaner code and easier maintenance.
* **Command Query Responsibility Segregation (CQRS):**  The application implements CQRS, differentiating between read and write operations for improved performance and scalability.
* **MediatR Integration:**  MediatR is utilized to facilitate communication between different project layers effectively, promoting loose coupling.
* **AutoMapper Integration:**  AutoMapper simplifies object mapping between entities and view models, reducing boilerplate code.
* **Fluent Validation:**  Fluent Validation is incorporated to enforce data integrity and provide clear error messages, enhancing application robustness.
* **ASP.NET 8 Blazor UI:**  A Blazor web interface is planned to provide a user-friendly frontend for interacting with the application.

**Project Structure:**

The solution is structured with separation of concerns in mind:

* **EventFlow.Core:** Encompasses the core application logic, including domain entities, commands, queries, and events.
* **EventFlow.Infrastructure:** Handles application infrastructure aspects like data access and persistence. (Implementation not included in this example)
* **EventFlow.API:**  This section (to be implemented) will house the ASP.NET 8 Core API for exposing application functionalities through well-defined endpoints.
* **EventFlow.Blazor.UI:**  A Blazor web application (to be implemented) will serve as the application's frontend, enabling user interaction with features.
* **EventFlow.Tests:**  A comprehensive testing suite (to be implemented) will ensure code quality and application reliability.

**Getting Started (Future Implementation):**

1. Clone the repository: `git clone https://github.com/your-username/EventFlow.NET.git`
2. Restore dependencies: `dotnet restore`
3. Run unit tests: `dotnet test` (Tests to be implemented)
4. Build the solution: `dotnet build`

**Further Enhancements (Future Implementation):**

* Implement infrastructure project for data persistence using Entity Framework Core or a similar ORM.
* Develop a robust ASP.NET 8 Core API for exposing application functionalities through RESTful endpoints.
* Construct a user-friendly Blazor web UI for seamless user interaction.
* Integrate unit testing frameworks like xUnit or NUnit for thorough code coverage.
* Implement logging mechanisms for application monitoring and debugging.
* Explore caching strategies for performance optimization.

**Contribution:**

We welcome contributions to this project! Feel free to fork the repository, create a pull request, and share your improvements.

**License:**

MIT License

**Author:**

[Ayoub Chaib](https://www.linkedin.com/in/chaib-ayoub/)

**Links:**

* Pull Request #1: [Creating the Domain Project](https://github.com/Vanhayten/EventFlow.NET/pull/1)

**Stay tuned for further development progress!**
