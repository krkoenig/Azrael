using UnityEngine;
using System.Collections;

public class MouseSelection : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject clicked = getSelectableAtClick();
        if(clicked != null)
        {
            Selectable s = clicked.GetComponentInChildren<Selectable>();
            s.isSelected = !s.isSelected;
        }
    }

    private GameObject getSelectableAtClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log(hit.transform.name);
            if (hit.transform.CompareTag("Selectable"))
                return hit.transform.gameObject;
        }

        return null;
    }
}
