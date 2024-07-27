dotnet new globaljson --sdk-version 8.0.203 --output CarServiceProject
dotnet new mvc --no-https --output CarServiceProject --framework net8.0
dotnet new sln -o CarServiceProject
dotnet sln CarServiceProject add CarServiceProject