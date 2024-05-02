using UnityEngine;
using UnityEngine.UI;

public class ToggleDrink : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToToggle;
    [SerializeField]
    private Transform objectToToggleTr;

    private Vector3 pos;

    public void Start()
    {
        if (objectToToggle != null) 
        { 
            objectToToggleTr = objectToToggle.GetComponent<Transform>(); 
            pos = objectToToggleTr.position;
        }
    }
    public void Toggle()
    {      
        if (objectToToggle != null)
        {   
            objectToToggle.SetActive(!objectToToggle.activeSelf);
            objectToToggle.transform.position = pos;
        }
    }
}
