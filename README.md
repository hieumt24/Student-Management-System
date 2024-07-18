# Student-Management-System

## Overview

## Features

## Technology Stack

- **Backend**: ASP.NET CORE WEB API
- **Frontend**: ReactJs
- **Database**: SQL Server

## Installation

### Prerequisites

- .NET SDK
- Node.js
- SQL Server

### Steps

1. **Clone the repository**:

   ```bash
   git clone https://github.com/hieumt24/Student-Management-System.git
   cd Student-Management-System

   ```

2. **Backend Setup**:

   ```bash
   cd backend
   cd src
   dotnet restore
   dotnet build
   dotnet run

   ```

3. **Frontend Setup**:

   ```bash
   cd frontend
   bun install or npm install
   bun run dev or npm start

   ```

4. **Database Setup**:

- Configure the connection string in `appsettings.Development.json`.
- Run the database migrations

Usage

- Access the application at http://localhost:3000.
- Log in with your credentials.
- Navigate through the dashboard to manage assets.
