using UnityEngine;
using Photon.Pun;
using System.Collections.Generic;

public class ChatManager : MonoBehaviourPun
{
    private string currentMessage = "";
    private List<string> chatMessages = new List<string>();
    private Vector2 scrollPos = Vector2.zero;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, Screen.height - 150, 300, 140));
        
        // Display Chat Messages
        scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Width(300), GUILayout.Height(100));
        foreach (string message in chatMessages)
        {
            GUILayout.Label(message);
        }
        GUILayout.EndScrollView();

        // Input Field and Send Button
        GUILayout.BeginHorizontal();
        currentMessage = GUILayout.TextField(currentMessage, GUILayout.Width(200));
        if (GUILayout.Button("Send", GUILayout.Width(80)))
        {
            SendMessageToChat(currentMessage);
            currentMessage = ""; // Clear the input field
        }
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }

    void SendMessageToChat(string message)
    {
        if (!string.IsNullOrEmpty(message.Trim()))
        {
            photonView.RPC("ReceiveMessage", RpcTarget.All, PhotonNetwork.NickName, message);
        }
    }

    [PunRPC]
    void ReceiveMessage(string senderName, string message)
    {
        string formattedMessage = $"{senderName}: {message}";
        chatMessages.Add(formattedMessage);
    }
}
