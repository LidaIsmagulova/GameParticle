using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
  public float Radius;
  public float Force;
  public AudioSource aus;
  public GameObject particalExplosion;

  public Transform transTexture;

  void Update()
  {
    if(Input.GetKeyDown(KeyCode.B))
    {
        Explose();
    }
  }

  public void Explose()
  {
    ExploseForce();
    aus.Play();
    Destroy(gameObject);
    Instantiate(particalExplosion,transform.position,transform.rotation);
   

  }

  public void ExploseForce()
  {
    Collider[]col=Physics.OverlapSphere(transform.position,Radius);
    foreach(Collider hit in col)
    {
        Rigidbody rg=hit.GetComponent<Rigidbody>();
        if(rg)
        {
            rg.AddExplosionForce(Force,transform.position,Radius,3f);
        }
    }
  }
}
