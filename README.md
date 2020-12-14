# Awesome FizzBuzz

FizzBuzz test solution using Blazor WebAssembly on .net5, Docker and nginx :)

## Description

Project structure:

- FizzBuzz (Web Aplication---Include Dockerfile, and Nginx config)
- FizzBuzz.UnitTest (Component responsible for carrying out the unit tests)
- Microsoft.AspNetCore.Components.Testing(Pluging for unit-test)

## Deployd
Download project Repoitory `` git clone git@github.com:mcardenash1/FizzBuzz.git``

### Using Docker

#### Requirements

| Name      | Version |
| --------- | ------- |
| docker-ce | 17.09(This is the version I use in my Solution) |

Move to the Dockerfile directory (FizzBuzz\FizzBuzz)
1. docker build -t fizzbuzz-webassembly .
2. docker run -p 8080:80 fizzbuzz-webassembly
3. http://localhost:8080

### Normal deploy

#### Requirements

| Name      | Version |
| --------- | ------- |
| .net5   | sdk:5.0  |

Move to the Project directory
1. Move to the Web Aplication folder (FizzBuzz\FizzBuzz)
2. dotnet build "FizzBuzz.csproj"
3. dotnet run
4.  http://localhost:5000 or  http://localhost:5001

### Using VS
1. Load the Project
2. Build the project (FizzBuzz.sln)
3. Run the project 

## Run Unit Test
In my Personal Case use VS
https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2019


