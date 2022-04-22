# Nopcommerce Plugin Templates

![](https://raw.githubusercontent.com/kazirahiv/Nopcommerce-Plugin-Template/main/icon.png)

Nopcommerce Plugin Templates is a bundle of multiple templates which helps creating different kind of Nopcommerce plugin/extensions at ease. 

## Installation

Use the dotnet new cli to install the Nuget package.
Latest: Nop.Plgugin.Templates.1.0.0.nupkg


```
dotnet new -i Nop.Plgugin.Templates.1.0.0.nupkg
```

![](https://raw.githubusercontent.com/kazirahiv/Nopcommerce-Plugin-Template/main/samples/1.png)

It currently supports three different plugin/extension types. (Payment, Miscellaneous and Widget). If you want to add more, the repository is open to add more supports 😎 

## Example Usage (Visual Studio 2022)

Select File>New>Project or Right click in your solution > Add > New project 

Select from available options 

![](https://raw.githubusercontent.com/kazirahiv/Nopcommerce-Plugin-Template/main/samples/2.png)


Put your plugin name and set Plugins path of your Nopcommerce project

![](https://raw.githubusercontent.com/kazirahiv/Nopcommerce-Plugin-Template/main/samples/3.png)


Customize as you want 

![](https://raw.githubusercontent.com/kazirahiv/Nopcommerce-Plugin-Template/main/samples/4.png)


## Example Usage (CLI)

Scaffold a plugin with CLI using short name 
``` 
dotnet new nop-payment
```

Use -h parameter to get available parameter options 

``` 
dotnet new nop-payment -h 
```
![](https://raw.githubusercontent.com/kazirahiv/Nopcommerce-Plugin-Template/main/samples/5.png)


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://github.com/kazirahiv/Nopcommerce-Plugin-Template/blob/main/LICENSE)
