# About ExpAndrew

#### This project is all about ME! I know that might seem conceited, but like, I mean literally; it is about me. {8/25/2017}_

#### By Andrew Dalton

## Description

This Web Application has been built to provide inquiring minds with a whole lot of information about myself, Andrew Dalton. It includes a landing page, an About Page, a page for some of my Favorite Things, Favorite Places, Favorite People, and my Favorite Pet, and it links to some of my best projects in Github using an API.

## Planning

1. Configuration/dependencies
	*Microsoft.NETCore.App: 1.0.1
	*Microsoft.ApplicationInsights.AspNetCore: 1.0.0,
	*Microsoft.AspNetCore.Diagnostics: 1.0.0,
	*Microsoft.AspNetCore.Mvc: 1.0.1,
	*Microsoft.AspNetCore.Razor.Tools: 1.0.0-preview2-final
	*Microsoft.AspNetCore.Routing: 1.0.1,
	*Microsoft.AspNetCore.Server.IISIntegration: 1.0.0,
	*Microsoft.AspNetCore.Server.Kestrel: 1.0.1,
	*Microsoft.AspNetCore.StaticFiles: 1.0.0,
	*Microsoft.Extensions.Configuration.EnvironmentVariables: 1.0.0,
	*Microsoft.Extensions.Configuration.Json: 1.0.0,
	*Microsoft.Extensions.Logging: 1.0.0,
	*Microsoft.Extensions.Logging.Console: 1.0.0,
	*Microsoft.Extensions.Logging.Debug: 1.0.0,
	*Microsoft.Extensions.Options.ConfigurationExtensions: 1.0.0,
	*Microsoft.VisualStudio.Web.BrowserLink.Loader: 14.0.0

2. Specifications
| Behavior | Input | Output |
| :--------| :---- | :------|
| The user can access the Landing Page (Index) | click IIS Express | "Welcome to my webpage..." |
| The user can navigate to the About Page | click About link | "About Me..." |
| The user can navigate to the Projects Page | click Projects link | "Here are some of my projects..."
| The user can access some of my Projects | click Project link | Displays Github repository |
| The user can navigate to the FavoriteThings Page | click Things link | "These are a few of my favorite things..."|
| The user can navigate to the FavoritePeople Page | click People link | "These are some of my favorite people..." |
| The user can navigate to the FavoritePet Page | click Pet link | "This is Pockets! He's pretty great...'" |

3. Integration
  * HomeController - for routing and file integration.
  * Project.cs - our Project Model.
  * Owner.cs - A model for a Repository Owner.
  * Index.cshtml - our Landing Page.
  * About.cshtml - a page about ME!
  * Contact.cshtml - a page for information about getting in touch with me.
  * People.cshtml - a page about my favorite people.
  * Pet.cshtml - a page about my cat, Pockets!
  * Places.cshtml - a page about my favorite places.
  * Projects.cshtml - a page about my favorite places.
  * Things.cshtml - a page about my favorite things.


## Setup/Installation Requirements

* Open your console or powershell command line.
* In your command line, navigate to the desktop or your desired folder destination.
* Copy the project's github address (https://github.com/drewlinn/expandrew.git)
* Write in your console the command "git clone" and paste the project address afterward and press enter.
* Log in to Github. From the drop down menu next to your user portrait click, 'Settings', and under the 'Developer Settings' category, click 'Personal Access Tokens'. Then click 'Generate New Token'. Select your desired Scope settings, and optionally enter a description. Then click 'Generate Token'.
* Open the project using Visual Studio. 
* Create a Class file in the project directory called 'EnvironmentVariables'.
* Insert the following lines of code in the EnvironmentVariables Class:
		public static string AccountSid = "YourGithubUserName";
        public static string AuthToken = "YOUR-API-KEY-GOES-HERE";
        public static string GitHubUserAgent = "User-Agent: "YourGithubUserName";"
	Then save the file.
* Right click on the project in the Solution Explorer Pane and click "Build".
* Once this process is complete, in Visual Studio, click on the button in the tool bar with the green PLAY SYMBOL that says "IIS EXPRESS" next to it.
* Your default web browser should open and navigate to the designated localhost automatically.
* The application should be displayed in your browser and operate with full functionality.

## Known Bugs

None currently known.

## Support and contact details

If you notice any bugs in my program or any other issues with my code, please email me at expandrew@gmail.com

## Technologies Used

*HTML 
*CSS 
*C# 
*Visual Studio 2015

### License

*This Software is Licensed under the MIT License*

Copyright (c) 2016 **Andrew Dalton, Epicodus**