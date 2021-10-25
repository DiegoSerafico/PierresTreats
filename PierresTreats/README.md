# _Pieres treats_

#### _This page allows public to view treats and flavors, and authorized users to make updates_

#### _**By Diego Serafico**_

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _.NET 5_

## Description

_This app is for Pierre and other authorized users to store a database of treats and associated flavors. Authorized users can add flavors, treats, as well as edit and delete them. The home page contains the lists of both treats and flavors, and can be viewed without logging in. From there you can click on them and see their details._

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

* _Clone this repository to your desktop_
* _Open in text editor_
* _Create appsettings.json in /PierresTreats/PierresTreats directory_
* _Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=diego_serafico;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _open new terminal and run SQL ($ mysql -uroot -p{your_password})_
* _open MySQL Workbench_
* _In the Navigator > Administration window, select Data Import/Restore.
* _In Import Options select Import from Self-Contained File_
* _Navigate to diego_serafico.sql located on the root directory of the project_
* _Under Default Schema to be Imported To, select the New button & Enter diego_serafico as name of database_
* _Click Ok_
* _Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window_
* _After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The diego_serafico database should appear._
* _In terminal, navigate into PierresTreats/PierresTreats/ and enter the command $ dotnet restore, to install necessary packages_
* _enter command $ dotnet build, to build program_
* _enter command $ dotnet run, to view program in your browser_
* _press ctrl or cmd and click on the localhost link_ 

## Known Bugs

* _NA_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_

## Contact Information
  
Diego Serafico: <dseraficohernandez@gmail.com> 🍃