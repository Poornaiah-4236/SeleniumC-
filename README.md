This project is a test automation framework built using modern tools and best practices for web application testing. It supports scalable, maintainable, and reusable automated test execution.
ech Stack
Language: C# / Java (update based on your project)
Automation Tool: Selenium
Test Framework: NUnit
Build Tool: .NET CLI
Version Control: Git
Project Structure
TechMehendra/
│
├── 📁 Properties/
│
├── 📁 References/
│
├── 📁 BaseTest/
│   └── (Driver setup, base class, test initialization)
│
├── 📁 Config/
│   └── (Configuration readers, environment settings)
│
├── 📁 Pages/
│   └── (Page Object Model classes)
│
├── 📁 Reports/
│   └── (Extent reports / test execution reports)
│
├── 📁 TestData/
│   └── (Test data files – JSON / Excel)
│
├── 📁 Tests/
│   └── (Test cases / test classes)
│
├── 📁 Utilities/
│   └── (Reusable helper methods – waits, screenshots, etc.)
│
├── 📄 app.config
│   └── (Application configuration – URL, browser, etc.)
│
├── 📄 packages.config
│   └── (NuGet package references)

1. Prerequisites
Make sure you have the following installed:
.NET SDK
IDE (Visual Studio)
Git
Browser (Chrome / Edge/FireFox)
2. Clone Repository
git clone https:github.com/Poornaiah-4236/SeleniumC-.git
cd TechMehendra
3. Restore Dependencies
For .NET:
dotnet restore
4. Configure Test Settings
Update configuration file:
Config/appsettings.json
Example:
{
  "baseUrl": "https://parabank.parasoft.com/",
  "browser": "chrome"
}
Test Reports
Reports are generated in:
/Reports/
Extent Reports
