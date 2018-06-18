using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class Framework : MonoBehaviour {

    public GameObject player;

    Thread receiveThread;
    UdpClient client;
    public int port;

    public string lastPacket = "";
    public string allPacket = "";

    float xpos;
    float ypos;
    float zpos;

    //int x = Camera.main.pixelWidth / 640;
    //int y = Camera.main.pixelHeight / 480;

    Camera main;

    public float sensitivity = 1f;
    public float sensitivity2 = 0.06f;

    void OnGUI()
    {
        Rect rectObj = new Rect(40, 10, 200, 400);

        GUIStyle style = new GUIStyle();

        style.alignment = TextAnchor.UpperLeft;

        GUI.Box(rectObj, "# UDPReceive\n127.0.0.1 " + port + " #\n"

                  //+ "shell> nc -u 127.0.0.1 : "+port +" \n"

                  + "\nLast Packet: \n" + lastPacket

                  //+ "\n\nAll Messages: \n"+allReceivedUDPPackets

                  , style);

    }

    // Use this for initialization
    void Start () {
        startClient();
        main = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        //player.transform.position = new Vector3(xpos, ypos, -7);
        player.transform.position = main.ScreenToWorldPoint(new Vector3(Screen.width - xpos, Screen.height - ypos, -7 - main.transform.position.z)) + (Vector3.forward * (zpos - 40) * sensitivity2);
    }

    private void startClient()
    {
        port = 7777;

        receiveThread = new Thread(new ThreadStart(receiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void receiveData()
    {
        client = new UdpClient(port);
        while (true)
        {
            try
            {
                IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                Byte[] data = client.Receive(ref IP);

                string text = Encoding.ASCII.GetString(data);
                //print(">> " + text);
                lastPacket = text;
                //allPacket = allPacket + text;
                string[] circles = text.Split('|');
                //lastPacket += "\nX: " + circles[0] + " Y: " + circles[1] + " Z: " + circles[2];
                var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                culture.NumberFormat.NumberDecimalSeparator = ",";
                xpos = float.Parse(circles[0], culture);
                ypos = float.Parse(circles[1], culture);
                zpos = float.Parse(circles[2], culture);
                lastPacket += "\nX: " + xpos + " Y: " + ypos + " Z: " + zpos;
                print(">> " + lastPacket);
                xpos *= sensitivity;
                ypos *= sensitivity;
                zpos *= sensitivity;
            }
            catch (Exception e)
            {
                print(e.Message);
            }
        }
    }

    void OnApplicationQuit()
    {
        if (receiveThread != null)
        {
            receiveThread.Abort();
            Debug.Log(receiveThread.IsAlive); //must be false
        }
    }
}
