# BookingFast 🚀

**This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs).
**

Welcome to BookingFast, a project utilizing the Onion Architecture pattern to build a robust and scalable booking system.

## Project Structure 🏗️

### 1. BookingFast.Application 📱

The `BookingFast.Application` layer represents the application's core logic. It contains the use cases and application services responsible for coordinating the application's behavior.

### 2. BookingFast.Domain 🌐

The `BookingFast.Domain` layer encapsulates the domain model, including entities, aggregates, and domain services. It defines the core business logic and rules.

### 3. BookingFast.Infrastructure 🛠️

In the `BookingFast.Infrastructure` layer, the focus is on external concerns like data access, external services, and infrastructure-related code. This layer is responsible for implementing repositories, data access logic, and any external dependencies.

### 4. BookingFast.UI 🖥️

The `BookingFast.UI` layer is the user interface layer, handling user interactions and presenting information to users. This layer is kept thin, with most of the application's logic residing in the `Application` layer.

## Getting Started 🚦

To get started with BookingFast, follow these steps:

1. Clone the repository.
   ```bash
   git clone https://github.com/zangassis/bookingfast
   ```

2. Navigate to the project directory.
   ```bash
   cd BookingFast
   ```

## How to Contribute 🤝

If you'd like to contribute to BookingFast, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and submit a pull request.

## License 📄

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments 🙌

Special thanks to contributors and everyone who supported the development of BookingFast.

Happy coding! 🚀✨
