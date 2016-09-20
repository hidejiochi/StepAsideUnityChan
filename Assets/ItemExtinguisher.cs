using UnityEngine;
using System.Collections;

public class ItemExtinguisher : MonoBehaviour {

    private GameObject unitychan;

    private float difference;

	// Use this for initialization
	void Start () {

        this.unitychan = GameObject.Find("unitychan");

        
	
	}
	
	// Update is called once per frame
	void Update () {

        this.difference = unitychan.transform.position.z - 10f;

        if (this.transform.position.z < this.difference)
        {
            Destroy(gameObject);
        }
	
	}
}
