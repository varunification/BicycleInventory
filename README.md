# Bicycle Inventory System

## Overview

The Bicycle Inventory System is designed to manage the production and inventory of bicycles. It utilizes a modular and flexible design pattern to represent the components of a bicycle, such as Frame, Pedals, Seat, Tyre, WheelFrame, and Wheels. The system allows for the creation, assembly, and tracking of bicycles with varying specifications.

## Table of Contents

- [System Components](#system-components)
- [Database Schema](#database-schema)
- [Design Patterns](#design-patterns)
- [Getting Started](#getting-started)
- [Usage Examples](#usage-examples)

## System Components

### 1. Frame

Represents the chassis or body of a bicycle.

### 2. Pedals

Represents the pedals of a bicycle.

### 3. Seat

Represents the seat of a bicycle.

### 4. Tyre

Represents the tyres of a bicycle.

### 5. WheelFrame

Represents the frame of a wheel.

### 6. Wheels

Represents the wheels of a bicycle, composed of Tyre and WheelFrame components.

### 7. Bicycle

The main entity representing a complete bicycle, composed of Frame, Pedals, Seat, Tyre, WheelFrame, and Wheels.

## Database Schema

The database schema reflects the relationships between different components of the system.

[Include Database Schema Diagram]

## Design Patterns

The system follows the Composite Design Pattern to represent the hierarchical structure of bicycle components. Each component can have sub-components, allowing for a modular and extensible design.

### Composite Design Pattern

- **Component**: The common interface or abstract class for all concrete classes.
- **Leaf**: Represents the individual parts (e.g., Frame, Pedals) that do not have sub-components.
- **Composite**: Represents the higher-level components (e.g., Wheels, Bicycle) that can have sub-components.

## Getting Started

1. Clone the repository.
2. Configure the database connection in the `appsettings.json` file.
3. Run the database migrations to create the necessary tables.
4. Build and run the application.

## Usage Examples

[Provide code snippets or examples of how to create, assemble, and query bicycles using the system.]

