# PersianNumber
simple and light persian number converter, for use in .NET Core projects.
  
## Adding Moraba.Persian.Numbers.Core package to your .NET Core project

  you can add this package from nuget.

## Package Manager
   Install-Package Moraba.Persian.Numbers.Core 
## .NET CLI 
   dotnet add package Moraba.Persian.Numbers.Core 
   
## usage

```c#

      try
      {
          //convert persian number to english
          string persianNumbers = "-۱۲۳۴۵"; 
          string englishNumber =  Moraba.Persian.Numbers.Convert.PersianToEnglish(persianNumbers);;
          //output : "-12345"
          
          //convert numbers to persian text
          string numberText =  Moraba.Persian.Numbers.Convert.NumberToText(persianNumbers);
          //output : "منفی دوازده هزار و سیصد و چهل و پنج"
          
      }
      catch (Exception ex)
      {
          Console.WriteLine(ex.Message);
      } 

``` 
##
![https://github.com/mojtabamoradi/PersianNumber](https://raw.githubusercontent.com/mojtabamoradi/Moraba/master/logo.png)
