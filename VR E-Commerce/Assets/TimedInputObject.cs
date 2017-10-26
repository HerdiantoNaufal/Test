using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class TimedInputObject : MonoBehaviour, TimedInputHandler {
    public Text data;
    public GameObject name;
    public string name2;
    public string name3;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleTimedInput()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        name = GameObject.Find("sphere");
        name2 = name.ToString();
        string[] split = name2.Split(' ');
        name3 = split[0];
        //print (name3);
        //print((split[0]).ToString());
        StartCoroutine(update(name3));
    }

    IEnumerator barang()
    {
        WWW itemsdata = new WWW("http://somethingnotright.dx.am/barang.php");
        print("masuk WWW");
        yield return itemsdata;
        print("masuk Yield");
        //WWW jumlah = new WWW("http://somethingnotright.dx.am/jumlah.php");
        //print("masuk jumlah");
        //yield return jumlah;
        //print("masuk Y Jumlah");
        //string itemsdatastring = itemsdata.text;
        //print(itemsdatastring);
        //data.text = itemsdatastring;
    }

    IEnumerator update(string namas)
    {
        print(name3);
        //WWW jumlah = new WWW("http://somethingnotright.dx.am/jumlah.php");
        UnityWebRequest link = UnityWebRequest.Get("http://somethingnotright.dx.am/jumlah.php?name3=" + namas);
        yield return link.Send();
        print("masuk jumlah");
        //yield return jumlah;
        //print("masuk Y Jumlah");
    }
}
