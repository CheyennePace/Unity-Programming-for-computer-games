using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
  [SerializeField] AudioClip BreakSound;
  Level level; 
  void start()
  {
    //find object level and assign to level
    level = FindObjectOfType<Level>();
    //add 1 to breakableBlocks
    level.CountBreakableBlocks();
  }
  private void OnCollisionEnter2D(Collision2D coll)
  {
    
    AudioSource.PlayClipAtPoint(BreakSound, Camera.main.transform.position);
    FindObjectOfType<GameStatus>().AddToScore();
    Destroy(gameObject);

    level.BlockDestroyed();
  }
}
