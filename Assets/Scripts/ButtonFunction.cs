using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonFunction : MonoBehaviour
{
    public GameObject cube;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("BlueButton").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(() => ChangeToBlue());
    }
    public void ChangeToCyan()
    {
        cube.GetComponent<Renderer>().material.color = Color.cyan;
    }
    public void ChangeToBlue()
    {
        cube.GetComponent<Renderer>().material.color = Color.blue;
    }
}
