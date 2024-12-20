# Competition Management System

## Overview
A management system designed to track competitions, competitors, and related activities. The system provides comprehensive tracking of competition statuses and participant information through a web-based interface.

## Features

### Competition Tracking
- Real-time status monitoring
- Competition scheduling
- Participant management
- Status updates and modifications
- Category-based organization

### Data Management
The system maintains two primary tables:
1. **Competition/Tournament Table** - Tracks active competitions with:
   - Competition ID
   - Creation Date
   - Modification Date
   - Status (Active/Deleted)
   - Competition Name
   - Category

2. **Category Management Table** - Organizes competitions by:
   - Creation Date
   - Modification Date
   - Category Status
   - Name

## API Endpoints

### Category Controller
```
GET     /api/Category                   # Get all categories
GET     /api/Category/{id}             # Get specific category
POST    /api/Category                  # Create new category
PUT     /api/Category/{id}             # Update category
DELETE  /api/Category/{id}             # Delete category
```

### Competition Controller
```
GET     /api/Competition               # Get all competitions
GET     /api/Competition/{id}          # Get specific competition
POST    /api/Competition              # Create new competition
PUT     /api/Competition/{id}         # Update competition
DELETE  /api/Competition/{id}         # Delete competition
```

## Technical Specifications

### Database Structure
- Implements soft delete functionality
- Tracks creation and modification timestamps
- Maintains referential integrity between competitions and categories

### Base Entity Properties
- ID (Primary Key)
- CreatedDate
- UpdatedDate
- IsDeleted (for soft delete functionality)

## Implementation Details

### Entity Framework Usage
- Utilizes Entity Framework Core for data access
- Implements repository pattern for data operations
- Maintains audit trail through timestamp tracking

### Security Features
- Implements soft delete instead of permanent records removal
- Maintains data integrity through proper relationship management
- Tracks all modifications with timestamp logging

## Getting Started

1. Clone the repository
2. Update database connection string in `appsettings.json`
3. Run database migrations:
   ```bash
   dotnet ef database update
   ```
4. Start the application:
   ```bash
   dotnet run
   ```

## Dependencies
- .NET Core 8.0+
- Entity Framework Core
- SQL Server/PostgreSQL (depending on configuration)
- ASP.NET Core MVC

## Best Practices
- Always use soft delete instead of hard delete
- Maintain audit trail through CreatedDate and UpdatedDate
- Use appropriate status codes in API responses
- Follow RESTful conventions for API endpoints

## Contributing
1. Fork the repository
2. Create a feature branch
3. Commit changes
4. Push to branch
5. Create Pull Request

## License
This project is licensed under the MIT License - see the LICENSE file for details.