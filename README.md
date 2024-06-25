# CSharpMSBuildVSCode-Starter

A minimalist C# project template using MSBuild and .NET Framework, optimized for Visual Studio Code development.

## Overview

This project provides a streamlined setup for C# development using tools that come preinstalled with Windows. It's designed for developers who:

- Work in environments without admin privileges
- Need to use the .NET Framework tools available on standard Windows installations
- Prefer a lightweight, IDE-independent development setup

## Why Preinstalled Tools?

We use `csc.exe` and `msbuild.exe` from the `C:\Windows\Microsoft.NET\Framework64\v4.0.30319\` directory for a crucial reason: **accessibility**. Many developers, especially in corporate environments, don't have admin rights on their machines. By leveraging these preinstalled tools, this template ensures that you can start coding immediately, without needing to install additional software or request admin permissions.

## Features

- Uses `csc.exe` for compilation and `msbuild.exe` for project building
- Configured for Visual Studio Code, but not dependent on it
- Includes tasks for building, running, and cleaning the project
- Minimal project structure for easy understanding and customization

## Prerequisites

- Windows OS with .NET Framework 4.0 or later installed (comes with most Windows versions)
- Visual Studio Code (recommended, but not required)

## Getting Started

1. Clone this repository:
   ```
   git clone https://github.com/Foadsf/CSharpMSBuildVSCode-Starter.git
   ```
2. Open the project folder in Visual Studio Code
3. Open the integrated terminal in VS Code
4. Build the project:
   ```
   C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe MyProject.csproj
   ```
5. Run the compiled executable:
   ```
   .\bin\Debug\MyProject.exe
   ```

## Project Structure

- `src/`: Contains your C# source files
- `MyProject.csproj`: The project file for MSBuild
- `.vscode/`: Contains VS Code-specific settings
  - `tasks.json`: Defines build, run, and clean tasks
- `build.bat`: A batch script for building, running, and cleaning the project

## Using VS Code Tasks

We've set up three tasks in VS Code for convenience:

- **Build**: Compiles the project (Ctrl+Shift+B)
- **Run**: Builds and runs the project
- **Clean**: Removes build artifacts

To use these tasks, press `Ctrl+Shift+P`, type "Tasks: Run Task", and select the desired task.

# CSharpMSBuildVSCode-Starter


## Building with build.bat

In addition to the VS Code tasks, we've included a `build.bat` script for those who prefer command-line operations or aren't using VS Code. This script provides a simple way to build, run, and clean the project.

### Using build.bat

1. Open a command prompt in the project directory.
2. Use the following commands:

   - To build the project:
     ```
     build.bat
     ```

   - To build and run the project:
     ```
     build.bat run
     ```

   - To clean the project (remove build artifacts):
     ```
     build.bat clean
     ```

### Customizing build.bat

The `build.bat` script is designed to be simple and easy to understand. You can open it in a text editor to customize the build process if needed. Here's a brief overview of what it does:

- It sets paths for MSBuild and the C# compiler.
- It defines the project file name and output directories.
- It provides separate commands for building, running, and cleaning the project.

Feel free to modify this script to suit your specific build requirements.

## Customizing the Project

Feel free to modify the `.csproj` file and the VS Code tasks to suit your specific needs. The minimal setup makes it easy to understand and adjust the build process.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the Apache License 2.0 - see the [LICENSE](LICENSE) file for details.
