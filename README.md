<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0b1120&height=250&section=header&text=WinPOS%20Inventory%20Desktop&fontSize=48&fontAlignY=38&desc=Enterprise-Grade%20Desktop%20Inventory%20System&descAlignY=58&descAlign=50&fontColor=4ade80" alt="Header Image" />

  **A professional Windows Desktop Point of Sale (POS) and Inventory Management system built with C# and WinForms.**
  
  [![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](#)
  [![.NET Framework](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](#)
  [![WinForms](https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)](#)
  [![SQL Server](https://img.shields.io/badge/SQL_Server-CC292B?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](#)
</div>

<br />

## 📜 Repository Information

**Repository Name:** `WinPOS-Inventory-Desktop`

**About / Description:** 
> A professional Windows Desktop Point of Sale (POS) and Inventory Management system built with C# and WinForms. Features complete database CRUD operations, real-time inventory tracking, and seamless SQL Server integration.

**Topics (Tags):**
`csharp`, `dotnet`, `winforms`, `desktop-application`, `point-of-sale`, `inventory-management`, `sql-server`, `ado-net`, `crud-operations`, `database-management`

---

## ⚡ Key Features

- **🛡️ Enterprise Architecture**: Robust C# WinForms structure utilizing ADO.NET for high-performance data access.
- **📦 Complete Inventory Management**: Full CRUD (Create, Read, Update, Delete) capabilities for products/items (`TBL_BARANG`).
- **🗄️ Real-Time Database Integration**: Seamless connection to SQL Server / LocalDB for immediate data persistence and retrieval.
- **⚡ Dynamic Data Binding**: Real-time rendering of inventory data through `DataGridView` with automatic UI updates upon data mutation.
- **🔒 Form Validation**: Comprehensive input validation to ensure data integrity before database transactions.
- **🧹 Clean UI/UX**: Intuitive desktop interface designed for fast-paced retail environments.

## 🛠️ Technology Stack

| Component | Technology | Version / Details |
| :--- | :--- | :--- |
| **Language** | C# | Object-Oriented Programming |
| **Framework** | .NET Framework | WinForms (Windows Forms) |
| **Database** | MS SQL Server | LocalDB (`MSSQLLocalDB`) |
| **Data Access** | ADO.NET | `System.Data.SqlClient` |

## 🚀 System Architecture & Database

The system relies on a local SQL Server database (`Kasir`). The core table is `TBL_BARANG` which tracks inventory details.

### Database Schema (`TBL_BARANG`)
- `KodeBarang` (Primary Key, VARCHAR)
- `NamaBarang` (VARCHAR)
- `HargaBeli` (NUMERIC)
- `HargaJual` (NUMERIC)
- `JumlahBarang` (INT)
- `SatuanBarang` (VARCHAR)
- `Distributor` (VARCHAR)

## 💻 Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/WinPOS-Inventory-Desktop.git
   ```

2. **Database Configuration**
   The application uses SQL Server Express LocalDB. Ensure you have LocalDB installed via Visual Studio Installer.
   Execute the provided PowerShell scripts to seed the database:
   ```powershell
   # Run the setup script to create database and tables
   .\setup_db.ps1
   
   # Run the seed data script to populate initial inventory
   .\seed_data.ps1
   ```

3. **Open the Project**
   Open the solution file using **Visual Studio**.

4. **Build and Run**
   Restore any necessary NuGet packages (if applicable) and press `F5` to compile and launch the application.

## 📸 Interface Preview

*(Upload screenshot aplikasi di repository ini, lalu ubah path link gambar di bawah ini)*
<div align="center">
  <img src="https://via.placeholder.com/800x450/0b1120/4ade80?text=Insert+Application+Screenshot+Here" alt="App Screenshot" width="800"/>
</div>

---
<div align="center">
  <sub>Built with 💻 | Engineered for efficiency.</sub>
</div>
