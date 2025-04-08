# NFLStatsGUI

This network-connected user interface allows the fetching, deserializing, and displaying of statistics from NFL games in the 2020 season. The system connects to an API, retrieves JSON data, and presents the information in an interactive UI.
The GUI is the second iteration of the [NFLStatsAPI](https://github.com/hcharise/NFLStatsAPI), which is a command-line version with additional functionality.

This project was completed by Hannah Ashton in March 2025 for Syracuse CSE 681 Software Modeling with Professor Gregory Wagner.

## Overall Structure

The overall structure consists of various classes and their interactions. Below is a high-level breakdown of the classes and their interactions.

<img width="300" alt="image" src="https://github.com/user-attachments/assets/223d5ff6-115c-4a3a-98da-045e754a6924" />

## Data Structures

The data structures used to store the data are designed around the structure of the JSON file containing the original statistics. The classes and objects are directly influenced by the structure of the data to ensure smooth deserialization and access.

1. **TeamMatchUpsThisSeason**: A list representing different matchups (games) for that team from the 2020 NFL season, as provided by the API.
2. **MatchUpStats**: Each game in the season is represented by a `MatchUpStats` object that holds general statistics for the game, such as the date, home team, visiting team, etc.
3. **TeamStatsThisMatchUp**: Each `MatchUpStats` object contains two `TeamStatsThisMatchUp` objects, one for the home team and one for the away team. These objects contain game-specific statistics for the respective teams, such as passing yards, penalties, and scores.

## Network Connectivity

Network connectivity is a crucial part of this system for fetching data from an external API. The system uses the `System.Net.Http` namespace to establish an HTTP connection to the API endpoint.

The URL for the API is constructed based on the team's number and game number, directing the system to the appropriate JSON file. This file is then read, deserialized, and stored in the relevant data structures.

API URL: [https://sports.snoozle.net/search/nfl/index.jsp?](https://sports.snoozle.net/search/nfl/index.jsp?)

## User Interface

The user interface is designed using XAML and is based on a grid layout. It consists of two main sections:

1. **Top Section (Gray)**: 
   - Users input a team number and a game number.
   - A button labeled "Show Stats" is used to trigger the display of data.
   - This section maintains a consistent height but adjusts its width based on the window size.

2. **Bottom Section (White)**:
   - Initially shows a welcome message that guides the user on how to use the system.
   - Displays error messages for invalid input, including rules for proper input.
   - Displays the relevant game statistics once valid input is provided.
  
<img width="1393" alt="image" src="https://github.com/user-attachments/assets/52121ec2-3f8c-4b1f-89ed-4fd6f7e2ff05" />

<img width="931" alt="image" src="https://github.com/user-attachments/assets/cb3cce7a-47e3-4eee-82d8-a5a8f57334c8" />

## Asynchronous/Multicore Computing

To ensure a responsive user interface, the system uses asynchronous programming to fetch and format data in the background. This allows the user to continue interacting with the interface without delays while the system processes and retrieves the necessary information.

## Features

- **Interactive UI**: Simple input fields and buttons for team/game selection.
- **Dynamic Data Display**: Displays relevant statistics based on user input.
- **Error Handling**: Displays appropriate error messages for invalid input.
- **Async Operations**: Ensures that fetching and processing data does not block the UI.

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/NFLStatsGUI.git
   ```
2. Open the project in Visual Studio.

3. Build and run the project.
