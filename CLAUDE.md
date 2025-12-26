# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a training program generator for Olympic weightlifting and powerlifting programs. The application generates personalized workout sessions based on program type, training day, and athlete statistics (primarily based on snatch max, from which all other lifts are calculated).

## Technology Stack

- **Framework**: ASP.NET Core MVC (.NET 10.0)
- **Architecture**: Layered architecture with dependency injection
- **Deployment**: Docker with multi-platform support (alpine-based images)
- **Caching**: In-memory caching for session calculations (15-minute sliding expiration)

## Project Structure

The solution follows a three-tier architecture organized into logical folders:

### Common Layer (`/Common/`)
- **Kudiyarov.TrainingPrograms.Entities**: Core domain entities (Stats, Session, Round, exercises, repeats)
- **Kudiyarov.TrainingPrograms.Programs**: Training program implementations (base class + specific programs)

### Business Logic Layer (`/BLL/`)
- **Kudiyarov.TrainingPrograms.Bll.Interfaces**: Business logic contracts
- **Kudiyarov.TrainingPrograms.Bll**: Core business logic implementation (TrainingProgramLogic)

### Data Access Layer (`/DAL/`)
- **Kudiyarov.TrainingPrograms.Dal.Interfaces**: Repository contracts
- **Kudiyarov.TrainingPrograms.Dal.Memory**: In-memory repository implementation

### Presentation Layer (`/PL/`)
- **Kudiyarov.TrainingPrograms.Web**: ASP.NET Core MVC web application

## Key Architecture Concepts

### Training Programs
All training programs inherit from the abstract `TrainingProgram` base class (Kudiyarov.TrainingPrograms.Programs/TrainingProgram.cs:7). Each program:
- Defines a collection of session-generating functions (lazily initialized)
- Implements GetSessions() to return session factories
- Uses the `Stats` record to calculate exercise weights based on athlete maximums

Programs are organized by category:
- **Competition**: Multi-week competition prep programs (split across partial classes for each week)
- **Strength**: Specialized strength programs (Deadlift, Legs, PullAndSquat)
- **Technique**: Olympic lift technique programs (Snatch, Clean, Jerk, Speed)
- **General**: Bodybuilding and muscle gain programs

### Stats Calculation System
The `Stats` record (Kudiyarov.TrainingPrograms.Entities/Stats.cs:3) uses a ratio-based approach where all lift maximums are derived from the athlete's snatch max. This ensures proper proportional loading across all exercises based on established strength ratios.

### Weight Processing Pipeline
Session weights are processed through TrainingProgramLogic (Kudiyarov.TrainingPrograms.Bll/TrainingProgramLogic.cs:59):
1. Calculate percentages from intensity and rep count
2. Add warmup sets for heavy exercises (progressive loading from 50% to work weight)
3. Calculate absolute weights from percentages
4. Optionally round weights to equipment increments (currently disabled)

### Dependency Registration
Service registration uses extension method in Kudiyarov.TrainingPrograms.Web/Extensions/DependencyInjectionExtensions.cs:10. Both business logic and repository are registered as singletons.

## Common Development Commands

### Build and Run
```bash
# Build the solution
dotnet build Kudiyarov.TrainingPrograms.slnx

# Run the web application
dotnet run --project Kudiyarov.TrainingPrograms.Web

# Build and run with Docker
docker compose up --build

# Build for specific platform
docker build --platform=linux/amd64 -f api.Dockerfile -t training-programs .
```

### Development
```bash
# Run the web application in development mode
cd Kudiyarov.TrainingPrograms.Web
dotnet run

# Watch mode for auto-rebuild
dotnet watch --project Kudiyarov.TrainingPrograms.Web
```

### Docker
```bash
# Build and run via compose (production mode on port 5000)
docker compose up --build

# Stop containers
docker compose down
```

## Adding New Training Programs

1. Create a new class in the appropriate category folder under `Kudiyarov.TrainingPrograms.Programs`
2. Inherit from `TrainingProgram` base class
3. Implement `Type`, `Name`, and `GetSessions()` properties
4. Register the program in `ProgramRepository` constructor (Kudiyarov.TrainingPrograms.Dal.Memory/ProgramRepository.cs:16)
5. Add corresponding `ProgramType` enum value in `Kudiyarov.TrainingPrograms.Entities/Enums/ProgramType.cs`

For multi-week programs, consider using partial classes with one file per week (see CompetitionProgram pattern).

## Important Implementation Details

- Sessions are cached in memory for 15 minutes to avoid recalculating weights
- The warmup generation algorithm (Kudiyarov.TrainingPrograms.Bll/TrainingProgramLogic.cs:79) only applies to exercises marked with `IsWarmupNeeded` and only for single-rep exercises with percentage-based loading
- Weight rounding is currently disabled (line 74) but infrastructure exists for barbell/dumbbell increments
- The repository pattern is used but currently only has in-memory implementation
- All projects target .NET 10.0 with nullable reference types enabled
