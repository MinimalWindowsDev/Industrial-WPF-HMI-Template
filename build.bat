@echo off
setlocal enabledelayedexpansion

set MSBUILD_PATH=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe
set CSC_PATH=C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe
set PROJECT_FILE=MyProject.csproj
set OUTPUT_DIR=bin
set OBJ_DIR=obj
set LOG_FILE=%OUTPUT_DIR%\build_log.txt
set EXE_NAME=MyProject.exe

if not exist %OUTPUT_DIR% mkdir %OUTPUT_DIR%

if "%1"=="clean" (
    echo Cleaning up...
    if exist %OUTPUT_DIR% rmdir /s /q %OUTPUT_DIR%
    if exist %OBJ_DIR% rmdir /s /q %OBJ_DIR%
    echo Clean complete.
    goto :eof
)

echo Building project...
"%MSBUILD_PATH%" %PROJECT_FILE% /p:Configuration=Release /p:Platform="Any CPU" /p:OutputPath=%OUTPUT_DIR% /fileLogger /fileLoggerParameters:LogFile=%LOG_FILE%;Append;Verbosity=diagnostic

if %ERRORLEVEL% neq 0 (
    echo Build failed. Check the log file at %LOG_FILE%
    exit /b %ERRORLEVEL%
)

echo Build successful. Output is in the %OUTPUT_DIR% directory.

if "%1"=="run" (
    echo Running the application...
    start "" "%OUTPUT_DIR%\%EXE_NAME%"
)

:eof
exit /b 0
