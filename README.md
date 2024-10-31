<div align="center">
  <!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
  <a name="readme-top"></a>
  <!--
  *** Thanks for checking out the Best-README-Template. If you have a suggestion
  *** that would make this better, please fork the repo and create a pull request
  *** or simply open an issue with the tag "enhancement".
  *** Don't forget to give the project a star!
  *** Thanks again! Now go create something AMAZING! :D
  -->

  <!-- PROJECT SHIELDS -->
  <!--
  *** I'm using markdown "reference style" links for readability.
  *** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
  *** See the bottom of this document for the declaration of the reference variables
  *** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
  *** https://www.markdownguide.org/basic-syntax/#reference-style-links
  -->

<!-- [![MIT License][license-shield]][license-url] -->
<!-- [![LinkedIn][linkedin-shield]][linkedin-url] -->

  <br />
  <a href="https://github.com/sorenly333/NotificationChannelParser.git">
    <img src="https://avatars.githubusercontent.com/u/110019765?v=4" alt="Logo" width="115" height="110">
  </a>

  <h1 align="center">Notification Channel Parser</h1>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#features">Features</a></li>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li>
      <a href="#usage">Usage</a>
      <ul>
        <li><a href="#code-structure">Code Structure</a></li>
        <li><a href="#key-classes">Key Classes</a></li>
        <li><a href="#customization">Customization</a></li>
        <li><a href="#sample-input-and-output">Sample Input and Output</a></li>
      </ul>
    </li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->

## About The Project

This Notification Channel Parser project is designed to streamline the categorization and delivery of notifications to specific teams based on tags found in the notification title. Each tag corresponds to a different team, and these tags are enclosed in square brackets. The main tags are as follows:

[BE]: Routes the notification to the Backend team.
[FE]: Routes the notification to the Frontend team.
[QA]: Routes the notification to the Quality Assurance (QA) team.
[Urgent]: Flags the notification as urgent, indicating it requires immediate attention.
The program scans the title for these tags, determines the appropriate team(s), and sends the notification accordingly. It handles tags in any order and disregards unrelated information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Mission

Our mission is to build an efficient, user-friendly C# program that categorizes notifications into teams based on tags in the notification title. By quickly identifying key tags—such as Backend (BE), Frontend (FE), Quality Assurance (QA), and Urgent—the program enables users to prioritize notifications and respond appropriately.

This tool is designed to highlight relevant information only, ensuring a streamlined, organized approach to handling notifications.

### Feature

- Tag Extraction: Detects and extracts relevant tags from the notification title.
- Channel Routing: Automatically directs notifications to the correct channels based on identified tags.
- Flexible Tag Handling: Accurately categorizes notifications regardless of tag sequence.
- Content Filtering: Ignores irrelevant content, focusing only on relevant tags to ensure precise routing.

### Built With

This section lists major frameworks and libraries used in the Learnwithkru project:

<a href="https://learn.microsoft.com/en-us/dotnet/csharp/" style="text-decoration: none;">
  <img src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png" alt="C#" title="C#" width="50" height="50" />
</a>
<a href="https://dotnet.microsoft.com/" style="text-decoration: none;">
  <img src="https://user-images.githubusercontent.com/25181517/121405754-b4f48f80-c95d-11eb-8893-fc325bde617f.png" alt=".NET Core" title=".NET Core" width="50" height="50" />
</a>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
<!-- LINKS -->

### Project Structure

The Notification Channel Parser project follows a monorepo structure. Here’s a brief overview:

```sh
/project-root
├── models
│   └── Notification.cs
├── services
│   └── NotificationService.cs
├── .gitignore
├── Notification-Parser.csproj
├── Program.cs
└── README.md

```

This structure keeps code modular and organized for easier maintenance and expansion.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->

## Getting Started

### Prerequisites
Ensure you have the following software installed:

[Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) (or any IDE supporting C#)
[.NET Framework SDK](https://dotnet.microsoft.com/download)

#### Setup Steps

1. Clone the project:

Open your terminal and run the following command to clone the project repository:

```sh
    git clone https://github.com/sorenly333/NotificationChannelParser.git
```

2. Navigate to the `Notification Channel Parser` folder:

Open your terminal and change the directory to the Notification Parserfolder. Replace path/to with the actual path to the project directory on your machine.

```sh
    cd NotificationChannelParser
```

3. Build the project:
   Once inside the project directory, use the following command to build the project:

```sh
 dotnet build
```

4. Run the project:
   After the build is complete, you can run the application with:

```sh
 dotnet run
```
<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Usage

The application processes sample notification titles and outputs the corresponding notification channels.

## Key Classes

- Notification: Represents a notification, containing the title as a string.
- ParseNotificationChannels: Uses regular expressions to extract tags (e.g., [Urgent], [FE]) from the notification title and map them to corresponding channels, like "Urgent" or "Frontend."

## Customization

To customize or extend the application, you can update the _tagChannelMap dictionary in the NotificationService class. This dictionary maps notification tags (e.g., [FE], [QA]) to human-readable channel names (e.g., "Frontend", "Quality Assurance").

```sh
// Define a set of valid notification channels
HashSet<string> validChannels = new HashSet<string> { "BE", "FE", "QA", "Urgent" };

```

## Sample Input and Output

Input Titles:

- [BE][FE][Urgent] there is error
- [BE][QA][HAHA][Urgent] there is error
  Output:

```sh
The notification should be input with []
Enter the notification title:

Input "[BE][FE][Urgent] there is error"
Output: "Receive channels: BE, FE, Urgent"

nput: "[BE][QA][HAHA][Urgent] there is error"
Output: "Receive channels: BE, QA, Urgent"
```

## CI/CD

```sh
name: CI for C# NotificationParser

on:
  push:
    branches:
      - main
  pull_request:
    branches:
      - main

jobs:
  build:
    runs-on: windows-latest  # Use a Windows environment

    steps:
      - name: Checkout code
        uses: actions/checkout@v2

      - name: Show folder structure
        run: |
          echo "Folder structure:"
          dir  # Lists all files and directories

      - name: Setup .NET Framework
        uses: actions/setup-dotnet@v1
        with:
          dotnet-version: '4.8.x'  # Specify the .NET Framework version

      - name: Restore dependencies
        run: nuget restore Notification-Parser.sln

      - name: Build the solution
        run: msbuild Notification-Parser.sln /p:Configuration=Release

      - name: Run tests
        run: |
          # Assuming you have tests in a separate project
          dotnet test YourTestProject.csproj --no-restore --verbosity normal

```
## Contributing

We encourage and welcome contributions! If you'd like to improve the application or add new features, follow these steps:


1. **Fork the repository.**
2. **Create a new branch**
   ```bash
   git checkout -b feature/YourFeatureName
   ```
3. **Make your changes and commit them**

```bash
git commit -m 'Add YourFeatureName'
```

3. **Push your branch**

```bash
git push origin feature/YourFeatureName
```

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For inquiries or questions about the project, feel free to reach out:

LY SOREN <br>
Telegram: https://t.me/soren_ly <br>
Email: sorenly333@gmail.com <br>
GitHub: [sorenly333](https://github.com/sorenly333)