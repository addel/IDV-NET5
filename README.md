# IDV-NET5

Required:

Visual Studio 2014
SQL EXPRESS (defaut install)
Have seen videos number 05 & 06 of IDV-NET5 UV ETNA

Name of Db name: IDV-NET5
Be care of the path of your DB server.

You need to create Db from model like "bin/console doctrine:schema:update --force" for symfo 

Go in your repository folder:
open terminal or CMD and tape:
"dotnet ef migrations add nameyouwant"
"dotnet ef database update"

to remove a migration:
"dotnet ef migrations remove"
