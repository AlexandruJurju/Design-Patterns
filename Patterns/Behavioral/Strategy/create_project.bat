@echo off
:: Hardcoded Folder Names
set "FOLDER_NAME=Document - TEST"
set "SOLUTION_NAME=DocumentSolution"
set "PROJECT_NAME=Strategy"

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
