using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputObject : MonoBehaviour, TimedInputHandler {
    public Text data;
    public GameObject name;
    public string name2;

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
        StartCoroutine(barang());
    }

    IEnumerator barang()
    {
        WWW itemsdata = new WWW("http://somethingnotright.dx.am/barang.php");
        yield return itemsdata;
        WWW jumlah = new WWW("http://somethingnotright.dx.am/jumlah.php");
        yield return jumlah;
        string itemsdatastring = itemsdata.text;
        print(itemsdatastring);
        data.text = itemsdatastring;
    }
}
