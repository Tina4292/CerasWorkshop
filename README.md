# CerasWorkshop

A modern web application built with ASP.NET Core (C#) delivering [brief project purpose or domain, e.g., "a small-scale inventory dashboard" or "a dynamic CRUD site for ceramic workshop management"].

---

##  Table of Contents

- [Demo](#demo)
- [Tech Stack](#tech-stack)
- [Features](#features)
- [Setup & Run](#setup--run)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contact](#contact)

---

##  Demo

**YouTube Demo:** [youtube.com/@tina4292](https://youtu.be/7e3HA0JXE4Y)

---

##  Tech Stack

- **Language & Framework**: C# | ASP.NET Core  
- **Frontend**: Razor Pages / MVC (HTML, CSS, JavaScript)  
- **Database**: SQLite (Dev) — adjustable via `appsettings.json`  
- **ORM/Migrations**: Entity Framework Core (via `Migrations/`)  
- **Server**: `.NET Core` (Program.cs entrypoint)

---

##  Features

- CRUD operations for workshop data (e.g., inventory, products)  
- Razor-based UI for smooth, server-rendered experiences  
- EF Core migrations for schema control (stored in `/Migrations`)  
- Config-based environment setup (via `appsettings.Development.json`)

---

##  Setup & Run

1. **Clone the repo:**
   ```bash
   git clone https://github.com/Tina4292/CerasWorkshop.git
   cd CerasWorkshop
2. **Restore dependencies**
   ```bash
   dotnet restore
4. **Update your database connection in appsettngs.json, if necessary**
5. **Apply migrations & create the database**
   ```bash
   dotnet ef database update
7. **Run the application**
   ```bash
   dotnet run
8. **Open http://localhost:5000 (or the URL displayed in your console)**

---

## Usage

- Navigate through the web UI to manage your project's relevant data
- Use the admin or custom dashboards (if any) to perform CRUD operations

---

## Project Structure
```pgsql
├─ .vscode/                       – IDE settings
├─ Migrations/                    – EF Core DB migrations
├─ Models/                        – Data models
├─ Pages/ or Controllers & Views/– UI endpoints (depending on Razor/MVC approach)
├─ Properties/                    – Build configuration 
├─ wwwroot/                       – Static assets (CSS, JS, images)
├─ appsettings*.json              – Configuration files
├─ CerasWorkshop.csproj           – Project file & dependencies
├─ Program.cs                     – App entrypoint
└─ database.db                    – SQLite DB (auto-generated; you may ignore in `.gitignore`)
```
---

## Contact

- **Author:** Tina [@Tina4292](https://github.com/Tina4292)
- **LinkedIn:** [linkedin.com/in/tina-coppedge-computer-information-systems](https://www.linkedin.com/in/tina-coppedge-computer-information-systems/)

