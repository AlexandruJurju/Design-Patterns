@echo off
:: Parameters
set "FOLDER_NAME=%~1"
set "SOLUTION_NAME=%~2"
set "PROJECT_NAME=%~3"

:: Default values if parameters are not provided
if "%FOLDER_NAME%"=="" set "FOLDER_NAME=DefaultFolder"
if "%SOLUTION_NAME%"=="" set "SOLUTION_NAME=DefaultSolution"
if "%PROJECT_NAME%"=="" set "PROJECT_NAME=DefaultProject"

:: Create the folder and navigate into it
mkdir "%FOLDER_NAME%"
cd "%FOLDER_NAME%"

:: Create the solution with the specified name
dotnet new sln -n "%SOLUTION_NAME%"

:: Create the project with the specified name
dotnet new console -n "%PROJECT_NAME%"

:: Add the project to the solution
dotnet sln "%SOLUTION_NAME%.sln" add "%PROJECT_NAME%\%PROJECT_NAME%.csproj"

echo Solution and project setup completed.
