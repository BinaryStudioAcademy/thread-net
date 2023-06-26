@ECHO off

TITLE DB scaffold

set /P migrationname="Enter migration name: " 

dotnet ef migrations add --project="..\Thread .NET.DAL\Thread .NET.DAL.csproj" %migrationname%

ECHO Db migration created

set /P applymigration="Apply migration (Y/N): " 

IF /I "%applymigration%" EQU "Y" (GOTO Apply) 
IF /I "%applymigration%" EQU "y" (GOTO Apply) 
GOTO Finished

:Apply
dotnet ef database update --project="..\Thread .NET.DAL\Thread .NET.DAL.csproj"

GOTO Finished


:Finished
ECHO Operation finished
PAUSE
GOTO Done

:No 
ECHO Operation canceled
GOTO Done

:Done