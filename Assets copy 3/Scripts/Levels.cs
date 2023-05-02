using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Levels : MonoBehaviour
{
  public int Level;

  void OnTriggerEnter(Collider col)
  {
    if(col.tag=="Player")
    {
        Application.LoadLevel(Level);
    }
  }
}
