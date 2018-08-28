using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using UnityEngine.UI;

public class GetIP : MonoBehaviour {

    public string IPAddressText;

    public void Start()
    {
        //IPAddressText.text = "My IP Address: " + Network.player.ipAddress;
        IPAddressText = "My IP Address: " + GetIp();
    }

    string GetIp()
    {
        string host_name = System.Net.Dns.GetHostName();
        IPHostEntry entry = System.Net.Dns.GetHostEntry(host_name);
        IPAddress[] addres = entry.AddressList;
        return addres[addres.Length - 1].ToString();
    }
}
