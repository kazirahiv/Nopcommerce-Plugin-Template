# Nopcommerce Plugin Templates

![](https://pbs.twimg.com/profile_images/1197439720957120517/bBMARwt8_400x400.png)

Nopcommerce Plugin Templates is a bundle of multiple templates which helps creating different kind of Nopcommerce plugin/extensions at ease. 

## Installation

Use the dotnet new cli to install the Nuget package.
Latest: Nop.Plgugin.Templates.1.0.0.nupkg


```
dotnet new -i Nop.Plgugin.Templates.1.0.0.nupkg
```

![](https://i.ibb.co/ngkYZvf/image.png)

It currently supports three different plugin/extension types. (Payment, Miscellaneous and Widget). If you want to add more, the repository is open to add more supports 😎 

## Example Usage (Visual Studio 2022)

Select File>New>Project or Right click in your solution > Add > New project 

Select from available options 

![](https://i.ibb.co/Z6B5w9G/image.png)


Put your plugin name and set Plugins path of your Nopcommerce project

![](https://i.ibb.co/ZxhgSmp/image.png)


Customize as you want 
![](https://i.ibb.co/z5TWmYF/image.png)


## Example Usage (CLI)

Scaffold a plugin with CLI using short name 
``` 
dotnet new nop-payment
```

Use -h parameter to get available parameter options 

``` 
dotnet new nop-payment -h 
```
![](https://i.ibb.co/Gv64b98/image.png)


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://github.com/kazirahiv/Nopcommerce-Plugin-Template/blob/main/LICENSE)