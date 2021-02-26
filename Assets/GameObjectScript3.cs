using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameObjectScript3 : MonoBehaviour
{
    public string fileName = "default.txt";
    public Text displayName;

    private string[] studentNames;


    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        ButtonClick();
    }

    private void LoadStudentNames()
    {
        this.studentNames = File.ReadAllLines(fileName);
    }

    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, this.studentNames.Length);
        string name = this.studentNames[i];
        displayName.text = name;
    }
}
