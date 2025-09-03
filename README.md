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
- [License](#license)
- [Contact](#contact)

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
