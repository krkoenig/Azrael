using UnityEngine;
using System.Collections;

public class Selectable : MonoBehaviour {

    public bool isSelected = false;

    private Projector selProj;

	// Use this for initialization
	void Start () {
        selProj = gameObject.GetComponent<Projector>();
	}
	
	// Update is called once per frame
	void Update () {
        selProj.enabled = isSelected;
    }
}
