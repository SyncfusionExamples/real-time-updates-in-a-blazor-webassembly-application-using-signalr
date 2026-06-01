# Real-time Updates in Blazor WebAssembly App using SignalR

A full-stack Blazor WebAssembly application demonstrating real-time appointment scheduling with instant synchronization across multiple clients using [SignalR](https://learn.microsoft.com/aspnet/core/signalr) and [Blazor Scheduler](https://www.syncfusion.com/blazor-components/blazor-scheduler) components.

![Blazor Scheduler with SignalR working](blazor-scheduler.gif)

## Overview

This sample application showcases how to build a collaborative scheduling experience in Blazor WebAssembly with real-time updates. When one user creates, edits, or deletes an appointment, all connected clients instantly receive and display the changes through a SignalR hub connection. The application uses the Blazor Scheduler component to provide a rich, interactive calendar interface.

**Key capabilities:**

- Multi-user real-time synchronization via SignalR
- CRUD operations on appointments (create, read, update, delete)
- Blazor Scheduler component with built-in drag-and-drop and inline editing
- Separated architecture with Client (WebAssembly), Server (ASP.NET Core), and Shared projects

## Features

- **Real-time Synchronization**: All connected clients receive instant updates when appointments are changed
- **Interactive Scheduler**: Built on Blazor Scheduler component with week view, inline editing, and drag-and-drop support
- **SignalR Integration**: Bidirectional communication between clients and server
- **Clean Architecture**: Organized into Client, Server, and Shared projects for maintainability
- **Activity Tracking**: Display notifications showing which user made what changes

## Architecture

The solution follows a three-project structure:

- **Client** (Blazor WebAssembly): The interactive UI running in the browser, featuring the Scheduler component and SignalR client logic
- **Server** (ASP.NET Core): Hosts the SignalR hub, serves static files, and provides REST API endpoints for appointment data
- **Shared**: Contains common models like `AppointmentData` shared between client and server

**Real-time Flow:**

1. User interacts with the Scheduler (creates, edits, or deletes an appointment)
2. Client sends changes via SignalR to the `SchedulerHub`
3. Hub broadcasts changes to all connected clients except the sender
4. All clients receive and apply the changes instantly

## Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/real-time-updates-in-a-blazor-webassembly-application-using-signalr.git
cd real-time-updates-in-a-blazor-webassembly-application-using-signalr
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

## References

- [SignalR documentation](https://learn.microsoft.com/aspnet/core/signalr)
- [Blazor Scheduler documentation](https://blazor.syncfusion.com/documentation/scheduler/getting-started-webapp)
- [Real-time ASP.NET Core applications with SignalR](https://learn.microsoft.com/aspnet/core/signalr/introduction)
