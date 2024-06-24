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
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CurrentObjectIndex == objects.Length + 1)
            {

            }
            else
            {
                objects[CurrentObjectIndex].SetActive(false);
                CurrentObjectIndex++;
                objects[CurrentObjectIndex].SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            objects[CurrentObjectIndex].SetActive(false);
            if (CurrentObjectIndex == -1)
            {
                CurrentObjectIndex = objects.Length;
            }
            else
            {
                CurrentObjectIndex--;
                objects[CurrentObjectIndex].SetActive(false);
            }
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
