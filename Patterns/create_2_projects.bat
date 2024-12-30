@echo off
:: Hardcoded Names
set "FOLDER_NAME=Example - Order Notifier"
set "SOLUTION_NAME=Observer"
set "PROJECT_NAME_GOOD=Good_Implementation"
set "PROJECT_NAME_BAD=Bad_Implementation"

:: Create the Good project
dotnet new console -n "%PROJECT_NAME_GOOD%"

:: Create the Bad project
dotnet new console -n "%PROJECT_NAME_BAD%"

:: Rename the project folder to the desired folder name
mkdir "%FOLDER_NAME%"
move "%PROJECT_NAME_GOOD%" "%FOLDER_NAME%"
move "%PROJECT_NAME_BAD%" "%FOLDER_NAME%"

:: Navigate into the renamed folder
cd "%FOLDER_NAME%"

:: Create the solution inside the same folder
dotnet new sln -n "%SOLUTION_NAME%"

:: Add the projects to the solution
dotnet sln "%SOLUTION_NAME%.sln" add "%PROJECT_NAME_GOOD%\%PROJECT_NAME_GOOD%.csproj"
dotnet sln "%SOLUTION_NAME%.sln" add "%PROJECT_NAME_BAD%\%PROJECT_NAME_BAD%.csproj"

echo Solution and projects setup completed.
pause
