# WPF-HMI-Starter

A minimalist WPF-based Human Machine Interface (HMI) template for Windows, designed for developers with limited installation privileges.

## Overview

This project provides a streamlined setup for developing Human Machine Interfaces (HMIs) using Windows Presentation Foundation (WPF). It's designed for developers who:

- Work in environments without admin privileges
- Need to use the .NET Framework tools available on standard Windows installations
- Want to create basic HMIs without installing additional software

This repository is a fork of [CSharpMSBuildVSCode-Starter](https://github.com/MinimalWindowsDev/CSharpMSBuildVSCode-Starter), adapted for WPF-based HMI development.

## Why Preinstalled Tools?

We use `csc.exe` and `msbuild.exe` from the `C:\Windows\Microsoft.NET\Framework64\v4.0.30319\` directory for a crucial reason: **accessibility**. Many developers, especially in corporate environments, don't have admin rights on their machines. By leveraging these preinstalled tools, this template ensures that you can start coding immediately, without needing to install additional software or request admin permissions.

## Features

- Uses `csc.exe` for compilation and `msbuild.exe` for project building
- Configured for Visual Studio Code, but not dependent on it
- Includes tasks for building, running, and cleaning the project
- Provides a basic WPF window with a simple HMI example
- Minimal project structure for easy understanding and customization

## Prerequisites

- Windows OS with .NET Framework 4.7.2 or later installed (comes with most Windows versions)
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

   or

   ```
   .\build.bat
   ```

5. Run the compiled executable:
   ```
   .\bin\Debug\MyProject.exe
   ```

   or

   ```
   .\build.bat run
   ```
6. To clean the project (remove build artifacts):

   ```
   build.bat clean
   ```

## Project Structure

- `src/`: Contains your C# source files and XAML
  - `MainWindow.xaml` and `MainWindow.xaml.cs`: Define the main window of the application
  - `App.xaml` and `App.xaml.cs`: Define the application
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


## Customizing the Project

Feel free to modify the `.csproj` file and the VS Code tasks to suit your specific needs. The minimal setup makes it easy to understand and adjust the build process.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the Apache License 2.0 - see the [LICENSE](LICENSE) file for details. This means:

- You can freely use, modify, and distribute this code, even for commercial purposes.
- You must include a copy of the license in any redistribution of the code.
- You must clearly state any significant changes made to the code.
- You must include a notice attributing the original work to this project.
