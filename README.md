# OpenMRS Automation Testing Project

This project is an automation testing suite for **OpenMRS** built using **C#**, **Selenium WebDriver**, and **XUnit Framework**. The project follows the **Page Object Model (POM)** design pattern for maintaining clean and reusable code. It automates the login process, validates the homepage, registers a patient, and facilitates appointment requests for doctors.

## Technologies Used

- **C#**: The primary programming language for the automation scripts.
- **Selenium WebDriver**: A framework for automating browser interaction.
- **XUnit**: Unit testing framework used for writing and running the tests.
- **Page Object Model**: A design pattern used to create object-oriented classes that serve as an interface to the web pages.
- **Test Explorer**: Used to run the tests and integrate with Visual Studio.

## Features

- Automated login validation with dynamic data.
- Home page validation after successful login.
- Patient registration functionality.
- Patient register page validation afetr successful register patient.
- And checks the patient name in the record sheet and selects the register patient 
- Request appointment for a doctor using the registered patient.
- Well-organized test scripts using Page Object Model for maintainability.

## Installation and Setup

Follow these steps to set up the project locally:

### Prerequisites

- **Visual Studio** (or any C# compatible IDE)
- **.NET Core SDK** (required for building and running the project)
- **Selenium WebDriver** and related packages

### Steps

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/OpenMRS-Automation.git
