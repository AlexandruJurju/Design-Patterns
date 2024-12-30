@echo off
:: Hardcoded Names
set "FOLDER_NAME=Example - File Export"
set "SOLUTION_NAME=Strategy"
set "PROJECT_NAME=Strategy"

:: Create the project with the specified name
dotnet new console -n "%PROJECT_NAME%"

:: Rename the project folder to the desired folder name
ren "%PROJECT_NAME%" "%FOLDER_NAME%"

:: Navigate into the renamed folder
cd "%FOLDER_NAME%"

:: Create the solution inside the same folder
dotnet new sln -n "%SOLUTION_NAME%"

:: Add the project to the solution
dotnet sln "%SOLUTION_NAME%.sln" add "%PROJECT_NAME%.csproj"

echo Solution and project setup completed.
