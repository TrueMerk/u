using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RegdollController : MonoBehaviour
{
   public float force = 100;
   public Transform cam;
   public Finisher finisher;
   private Rigidbody[] rb_AR;
   private bool _isActive = true ;
   private float curr;
   private void Start()
   {
      rb_AR = GetComponentsInChildren<Rigidbody>();
      foreach (var rb in rb_AR)
      {
         rb.isKinematic = true;
      }

      finisher.FinisherEvent += Reg;
      
   }

   private void Reg()
   {
      foreach (var rb in rb_AR)
      {
         rb.isKinematic = false;
      }

      _isActive = false;
      curr = 5 + Time.time;
      GetComponent<Animator>().enabled = false;
   }

   private void Update()
   {
      if (_isActive == false)
      {
         if (curr<=Time.time)
         {
            this.gameObject.SetActive(false);
            this.gameObject.SetActive(true);
            curr = Single.MaxValue;
         }
      }
   }

   private void OnEnable()
   {
      rb_AR = GetComponentsInChildren<Rigidbody>();
      foreach (var rb in rb_AR)
      {
         rb.isKinematic = true;
      }
      GetComponent<Animator>().enabled = true;
      
     SpawnPos();
   }

   private void SpawnPos()
   {
      var rX = Random.Range(-17f, 17f);
      var rZ = Random.Range(-17f,17f);
      var rPosition = new Vector3(rX, 0, rZ);
      
      this.transform.position = rPosition;
      
   }
}
