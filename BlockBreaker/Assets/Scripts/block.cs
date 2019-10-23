using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D coll)
  {
      Destroy(this.gameObject);
  }
}
