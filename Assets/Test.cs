using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int[] highScore = new int[10];
    public Rigidbody[] rb = new Rigidbody[10];
    public Test[] test;

    public List<int> ID = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < highScore.Length; i++) 
        {
            highScore[i] = i+1;
            highScore.SetValue(i + 1, i + 2);
            Debug.Log(highScore[i]);
            Debug.Log(highScore.GetValue(i+1));

        }

        for( int j = 0; j < ID.Count; j++)
        {
            ID.Add(j);
            ID.Remove(j+1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
