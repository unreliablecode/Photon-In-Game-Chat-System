Here's a sample `README.md` file for your in-game chat system using Photon PUN and Unity's IMGUI system:

---

# Photon In-Game Chat System

This Unity project demonstrates a simple in-game chat system using Photon PUN and Unity's default IMGUI system. Players can send and receive messages in real-time, with each message displayed in the format `{sender_name}: their chat`.

## Features

- **Real-time Messaging**: Players can send and receive messages in real-time across the network using Photon PUN.
- **IMGUI Interface**: The chat interface is created using Unity's IMGUI, providing a simple and easily customizable UI.
- **Multi-player Support**: Works seamlessly in a multi-player environment, ensuring all players see the same chat messages.

## Requirements

- **Unity**: Version 2021.3 or later.
- **Photon PUN 2**: Make sure you have Photon PUN installed and set up in your project. You can get it from the Unity Asset Store.

## Setup Instructions

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/unreliablecode/Photon-InGame-Chat.git
   ```

2. **Open in Unity**:
   - Open the project in Unity Editor.

3. **Configure Photon PUN**:
   - If you haven't already, set up Photon PUN in your project. Follow the [Photon PUN documentation](https://doc.photonengine.com/en-us/pun/current/getting-started/pun-intro) to connect your project to Photon.

4. **Attach the ChatManager Script**:
   - Create an empty GameObject in your scene and attach the `ChatManager` script provided in this repository.

5. **Run the Project**:
   - Make sure each player has a unique `PhotonNetwork.NickName` before connecting to the room.
   - Run the project, connect to a Photon room, and start chatting!

## How It Works

- **ChatManager Script**:
  - The `ChatManager` script handles sending and receiving chat messages using Photon PUN's `PunRPC` feature.
  - Messages are displayed using Unity's IMGUI system.

- **Message Format**:
  - Each message is displayed in the format `{sender_name}: their chat`.

## Example

![Chat UI Example](link-to-screenshot-or-gif)

## Customization

- **Adjust UI**: Modify the `OnGUI()` method in `ChatManager` to customize the chat window's appearance.
- **Add Features**: Extend the chat system by adding timestamps, private messaging, or other features according to your game's needs.

---
