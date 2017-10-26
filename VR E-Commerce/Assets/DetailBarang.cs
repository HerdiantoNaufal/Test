using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class DetailBarang : MonoBehaviour, TimedInputHandler
{
    public Text data;
    public GameObject name;
    public string name2;
    public string name3;

    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HandleTimedInput()
    {
        name = GameObject.Find("slippers");
        name2 = name.ToString();
        string[] split = name2.Split(' ');
        name3 = split[0];
        //StartCoroutine(update(name3));
        StartCoroutine(barang(name3));
    }

    IEnumerator barang(string namas2)
    {
        WWW itemsdata = new WWW("http://somethingnotright.dx.am/barang.php?name3=" + namas2);
        print("masuk WWW");
        yield return itemsdata;
        print("masuk Yield");
        string itemsdatastring = itemsdata.text;
        print(itemsdatastring);
        data.text = itemsdatastring;
        //print(name3);
    }

    IEnumerator update(string namas)
    {
        print(name3);
        
        UnityWebRequest link = UnityWebRequest.Get("http://somethingnotright.dx.am/jumlah.php?name3=" + namas);
        yield return link.Send();
        print("masuk jumlah");
    }

}
