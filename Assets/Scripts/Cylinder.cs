using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
   private const string PLAYER_TAG = "Player";
   public void Initialize(Color color)
   {
      var renderer = GetComponent<Renderer>();
      renderer.material.color = color;
   }
   
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.collider.CompareTag(PLAYER_TAG))
      {
         var player = collision.gameObject.GetComponent<Player>();
         Renderer cylinderRenderer = GetComponent<Renderer>();
         Color cylinderColor = cylinderRenderer.material.color;
         if (player.Color == cylinderColor)
         {
            Destroy(gameObject);
         }
      }
   }
   
   
   
}
