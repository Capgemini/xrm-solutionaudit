# Xrm Solution Audit

## Description

The Xrm Solution Audit supports a full analysis of specific components contained within any managed solutions in Microsoft Dynamics 365. This audit solution can target multiple versions of Microsoft Dynamics - CRM 2011, 2015, 2016 and Dynamics 365.

This tool is a .NET library that is intended to be consumed from any .NET application such as Console, Win Forms, Web applications, Azure DevOps etc. It is currently been released as a library which can be consumed through NuGet.

On completion of each audit, reports are generated which can be in any of the following formats:
* Excel Worksheet
* HTML
* JSON
* XML

Each report generation exercise can be configured to only return components that are published by specific Dynamics 365 publishers.

The output from each execution of the tool captures the following information.
* All solutions within the instance
* All entities within the instance
* Plugins
* Workflows
* Webresources
* Forms and Form Events
* Reports

## Table of Contents 
1. [Installation](#installation) 
2. [Usage](#usage) 
3. [Contributing](#contributing) 
4. [Credits](#credits) 
5. [License](#license)
  

Current build status: <img src="https://capgeminiuk.visualstudio.com/Capgemini Reusable IP/_apis/build/status/NUGET CI Builds/CRM%20SolutionAudit%20NUGET" alt="CI Build status">

## Installation

The Xrm Solution Audit tool is released via [NuGet](https://www.nuget.org/) and as such can be consumed from the following feed: [Capgemini Xrm Audit Reports](https://www.nuget.org/packages/Capgemini.Xrm.Audit.Reports/).

A reference to the above NuGet feed must be added to any application that intends to consume the solution audit tool.

To achieve this, perform the following steps:
1. Right-click on the project node in Solution Explorer and choose Mange NuGet Packages
2. Filter the displayed NuGet packages with "Capgemini.Xrm.Audit.Reports" 
3. Install the Capgemini.Xrm.Audit.Reports

A step-by-step listing of how to add this NuGet package to your solution can be found [here](https://github.com/Capgemini/xrm-solutionaudit/wiki/Console-Application-Example)

## Usage

Detailed documentation about this tool can be found in the [here](https://github.com/Capgemini/xrm-solutionaudit/wiki).

## Contributing

To contribute to this project
* Report any [issues](https://github.com/Capgemini/xrm-solutionaudit/issues)
* Submit changes via [pull requests](https://github.com/Capgemini/xrm-solutionaudit/pulls)
* Contribute to the [documentation](https://github.com/Capgemini/xrm-solutionaudit/wiki)

## Credits

Special thanks to the entire Capgemini community for their support in developing this tool.

## License
The Xrm Solution Audit is released under the [MIT](LICENSE) license.

























