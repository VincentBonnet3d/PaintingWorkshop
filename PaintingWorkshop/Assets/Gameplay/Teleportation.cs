using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleportation : MonoBehaviour
{
    
    void Update()
    {
        
        if(Input.GetKey(KeyCode.T))
        {
            Debug.Log("Load scene");
            SceneManager.LoadScene("Scene_PaintingWorkshop_salleVG");
        }

        if (Input.GetKey(KeyCode.Y))
        {
            Debug.Log("Load scene");
            SceneManager.LoadScene("Scene_PaintingWorkshop_Atelier");
        }
    }
}
