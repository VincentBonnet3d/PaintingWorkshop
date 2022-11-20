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
            Initiate.Fade("Scene_PaintingWorkshop_salleVG", Color.black, 1);
        }

        if (Input.GetKey(KeyCode.Y))
        {
            Initiate.Fade("Scene_PaintingWorkshop_Atelier", Color.black, 1);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
