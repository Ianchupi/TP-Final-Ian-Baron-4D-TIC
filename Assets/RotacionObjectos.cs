using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionObjectos : MonoBehaviour
{

    public GameObject[] objects;
    public int CurrentObjectIndex = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        DesactivarTodosObjetos();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivarNextObject();
        }
        else if ((Input.GetKeyDown(KeyCode.RightArrow)))
        {
            ActivarAntObject();
        }
        
           
        
    }


    public void ActivarNextObject()
    {

       

        CurrentObjectIndex++;


        if (CurrentObjectIndex >= objects.Length)
        {
            CurrentObjectIndex = 0;
        }
        DesactivarTodosObjetos();
        objects[CurrentObjectIndex].SetActive(true);

    }
    public void ActivarAntObject()
    {

        CurrentObjectIndex--;
        if (CurrentObjectIndex < 0)
        {
            CurrentObjectIndex = objects.Length - 1;
        }
        DesactivarTodosObjetos();
        objects[CurrentObjectIndex].SetActive(true);
    }

    void DesactivarTodosObjetos()
    {
        foreach (GameObject g in objects)
        {
            g.SetActive(false);
        }
    }

  
}
