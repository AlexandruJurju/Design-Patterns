import os
import subprocess

def create_dotnet_project():
    # Get parameters from user input
    folder_name = input("Enter the folder name: ")
    solution_name = input("Enter the solution name: ")
    project_name = input("Enter the project name: ")

    try:
        # Create the project with the specified name
        print(f"Creating new console project '{project_name}'...")
        subprocess.run(['dotnet', 'new', 'console', '-n', project_name], check=True)

        # Rename the project folder to the desired folder name
        print(f"Renaming folder to '{folder_name}'...")
        os.rename(project_name, folder_name)

        # Navigate into the renamed folder
        os.chdir(folder_name)

        # Create the solution inside the same folder
        print(f"Creating solution '{solution_name}'...")
        subprocess.run(['dotnet', 'new', 'sln', '-n', solution_name], check=True)

        # Add the project to the solution
        print("Adding project to solution...")
        subprocess.run(['dotnet', 'sln', f'{solution_name}.sln', 'add', f'{project_name}.csproj'], check=True)

        print("Solution and project setup completed successfully!")

    except subprocess.CalledProcessError as e:
        print(f"An error occurred while running dotnet commands: {e}")
    except OSError as e:
        print(f"An error occurred while manipulating files/directories: {e}")

if __name__ == "__main__":
    create_dotnet_project()