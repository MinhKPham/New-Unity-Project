using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {
    public Transform mainone;
    int i = 2;
    public Button button;
    public Button save;
    public InputField r;
    public InputField g;
    public InputField b;
    List<Transform> shapes= new List<Transform>() ;
    float rr=0;
    float gg=0;
    float bb=0;
    // Use this for initialization
    void Start () {
        button.onClick.AddListener(shape);
        save.onClick.AddListener(saveshape);
        r.text = "0";
        g.text = "0";
        b.text = "0";

    }
	
	// Update is called once per frame
	void Update () {

        if (r.text == "") { rr = 0; }
        else rr=float.Parse(r.text);
        if (g.text == "") { gg = 0; }
        else gg = float.Parse(g.text);
        if (b.text == "") { bb = 0; }
        else bb = float.Parse(b.text);
        mainone.GetComponent<meshobject>().c= new Color(rr,gg,bb);
        
        

    }
    void shape()
    {
        mainone.GetComponent<meshobject>().changeshape();
    }
    void saveshape()
    {
        Transform newone = Instantiate(mainone, new Vector3(-11f + i * 1.25f, -3, 0), Quaternion.identity);
        newone.GetComponent<meshobject>().setind(mainone.GetComponent<meshobject>().getind());
        newone.GetComponent<meshobject>().c = mainone.GetComponent<meshobject>().c;
        shapes.Add(newone);
        i++;
    }
}
