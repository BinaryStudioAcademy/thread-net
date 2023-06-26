read -p "Enter migration name: " migrationname

dotnet ef migrations add --project="..\Thread .NET.DAL\Thread .NET.DAL.csproj" $migrationname

echo Db migration created

read -p "Apply migration (Y/N): " applymigration

if [ $applymigration == "Y" ]
then 
dotnet ef database update --project="..\Thread .NET.DAL\Thread .NET.DAL.csproj"
fi

echo Operation finished
