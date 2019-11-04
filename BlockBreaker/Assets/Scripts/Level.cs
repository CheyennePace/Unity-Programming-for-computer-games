using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   
        [SerializeField] int breakableBlocks;

        SceneLoader sceneLoader;

        void Start()
        {
            sceneLoader = FindObjectOfType<SceneLoader();
        }

        public void BlockDestroyed()
        {
            breakableBlocks--;

            if(breakableBlocks <= 0)
            {
                sceneLoader.LoadNextScene();
            }
            
        }
        public void CountBreakableBlocks()
        {
            breakableBlocks++;
        }
    
}
