# Xrm Solution Audit

## Table Of Contents
1. [Description](#description) 
2. [Installation](#installation) 
3. [Usage](#usage) 
4. [Contributing](#contributing) 
5. [Credits](#credits) 
6. [License](#license)
  
----
Current build status: <img src="https://capgeminiuk.visualstudio.com/Capgemini Reusable IP/_apis/build/status/NUGET CI Builds/CRM%20SolutionAudit%20NUGET" alt="CI Build status">

## Description

The Xrm Solution Audit supports a full analysis of specific components contained within any managed solutions in Microsoft Dynamics 365. This audit solution can target multiple versions of Microsoft Dynamics - CRM 2011, 2015, 2016 and Dynamics 365.

This tool is a .NET library that is intended to be consumed from any .NET application such as Console, Win Forms, Web applications etc.

On completion of each audit, audit reports are generated which can be in any of the following formats:
* Excel Worksheet
* HTML site
* JSON
* XML

Each report captures the following details - though it depends on the chosen output format:
* All entities in the instance
* Plugins
* Workflows
* Webresources
* Forms and Form Events
* Reports


## Installation

The Xrm Solution Audit is currently released via [NuGet](https://www.nuget.org/) and as such can be consumed from the following feed: [Capgemini Xrm Audit Reports](https://www.nuget.org/packages/Capgemini.Xrm.Audit.Reports/).

A reference to the above NuGet feed must be added to any application that intends to consume the solution audit tool. To achieve this, perform the following steps:
1. Right-click on the project node in Solution Explorer and choose Mange NuGet Packages
4. Select the NuGet feed Xrm.SolutionAudit 
5. Choose your analyzer from the list and click install

## Usage

A detailed documentation about this tool can be found in the following [wiki](https://github.com/Capgemini/xrm-solutionaudit/wiki).

## Contributing

To contribute to this project, report any bugs, submit new feature requests, submit changes via pull requests or even join in the overall design of the tool.

## Credits

Special thanks to the entire Capgemini community for their support in developing this tool.

## License
The Xrm Solution Audit is released under the [MIT](LICENSE) license.

























