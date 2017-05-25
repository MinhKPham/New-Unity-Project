using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshobject : MonoBehaviour {
    public Mesh[] m;
    public Color c;
    int ind = 0;
    private bool mainone = true;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<MeshFilter>().sharedMesh = m[ind];
        GetComponent<MeshRenderer>().material.color=c;
        


    }
    public void changeshape()
    {
        ind++;
        if (ind > 2) ind = 0;
    }
    
    public int getind()
    {
        return ind;
    }
    
    public void setind(int i)
    {
        ind=i;
    }
}
