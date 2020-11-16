# Encompass-FNA-Template

Template (and VSCode build tasks) for developing a cross-platform multi-target .NET Framework and .NET Core game using Encompass and FNA.

## Features

- Includes project boilerplate code
- Build tasks for both .NET Framework and .NET Core side by side
- Press F5 to build and debug in-editor with Core Debugger

## Requirements

- [Git](https://git-scm.com/)
- [Git for Windows](https://gitforwindows.org/) if on Windows
- [Visual Studio Code](https://code.visualstudio.com/)
- [VSCode C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core)
- [.NET Framework SDK](https://dotnet.microsoft.com/download/visual-studio-sdks) or [Mono](https://www.mono-project.com/)


## Installation

- Make sure you have Git Bash from Git for Windows if you are on Windows
- Download this repository
- Run `install.sh`
- Move the newly created project directory wherever you want

## Usage

- Open the project directory in VSCode
- Press Ctrl-Shift-B to open the build tasks menu
- `Framework` tasks use .NET Framework or Mono to build and run
- `Core` tasks use .NET Core to build and run
- Press F5 to build and debug with Core Debugger

## Acknowledgments

Thanks to Andrew Russell and Caleb Cornett's FNA templates for a starting point for this template.
