using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private List<GameObject> models;
    private int selectionIndex = 0;
    public Button ChangHairStyle;
    
    public int SelectionIndex { get => selectionIndex; set => selectionIndex = value; }

    private void Start()
    {
        models = new List<GameObject>();
        foreach(Transform t in transform)
        {
            models.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }

        ChangHairStyle.onClick.AddListener(ChangeHair);

        models[SelectionIndex].SetActive(true);
    }

    public void ChangeHair()
    {
        models[selectionIndex].GetComponent<CustomizeModels>().SwitchHairs();
    }

    //Maus bewegen und bewegt model auch.
    private void Update()
    {
        if(Input.GetMouseButton(0))
            transform.Rotate(new Vector3(0.0f, Input.GetAxis("Mouse X"), 0.0f));
    }

    public void Select(int index)
    {
        if (index == SelectionIndex)
            return;
        if (index < 0 || index >= models.Count)
            return;


        models[SelectionIndex].SetActive(false);
        SelectionIndex = index;
        models[SelectionIndex].SetActive(true);

    }
}
