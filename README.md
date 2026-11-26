# Kids Weekly Schedule Planner

**Group:** 27 | **Class:** IT 2.2 

## Members

| Name | Reg No | GitHub | Main Work Done |
|------|--------|--------|----------------|
| Lewis Njuguna | C025-01-0798/2025 | Siwels26 | User management and login |
| Silvia Wanjiru | C025-01-0799/2025 | Silvia-Kinyua | Children Management |
| Salome Ndirangu | C025-01-0789/2025 | SallyShiicoder | Weekly Schedule Management |

## What the System Does

The Kids Weekly Schedule Planner is a desktop application designed to help parents manage their children's weekly activities and schedules. It allows parents to manage Kid Holder accounts, register children, assign children to Kid Holders and organize weekly activities. The system provides an organized way to monitor children's daily routines and avoid scheduling conflicts.

## Roles

- **Parent:** Can register and log in, manage Kid Holder accounts, manage children's records, assign children to Kid Holders and manage weekly schedules.
- **Kid Holder:** Can log in and access the children and schedules assigned to them, according to the permissions implemented in the system.

## Features Done

- Splash screen with database connection check
- Parent registration
- Login authentication
- Password hashing using BCrypt
- User session management
- Role-based dashboard
- Kid Holder account creation
- View Kid Holders
- Update Kid Holder details
- Delete Kid Holder accounts
- Parent-specific Kid Holder management
- Children Management (CRUD)
- Assign Children to Kid Holders
- Weekly Schedule Management
- Schedule search and filtering
- Schedule clash detection
- Weekly schedule viewing

## How to Run

1. Install Visual Studio with the .NET desktop development workload.
2. Install MySQL Server and MySQL Workbench.
3. Clone the project repository from GitHub.
4. Import the database script with the name `KidsScheduleDB` into MySQL.
5. The application uses a .env file to store database connection settings.
   - Open the project folder containing KidsWeeklySchedulePlanner.vbproj.
   - Create a text file named .env in that cloned folder.
   - Add the following configuration as it is using Notepad/ Notepad++:
       - DB_SERVER=localhost
       - DB_PORT=3306
       - DB_NAME=KidsScheduleDB
       - DB_USER=root
       - DB_PASSWORD=your_mysql_password
   - Replace your_mysql_password with your local MySQL password.
   - Save the file.
6. Open `KidsWeeklySchedulePlanner.sln` in Visual Studio.
7. Restore the required NuGet packages if necessary.
8. Build the solution.
9. Press F5 to run the application.

## Screenshots

Application screenshots are available in the `/screenshots` directory.

The screenshots demonstrate:
- Splash Screen
- Login Form
- Parent Dashboard
- Kid Holder Management
- Children Management
- Weekly Schedule Management

## Version Control

The project is developed collaboratively using Git and GitHub.

Each group member works on a separate development branch and submits completed work through Pull Requests for review and integration into the main branch.

## Project Status

**Development in Progress**

The application is being developed in modules by three group members, with all modules integrated into one Windows desktop application.