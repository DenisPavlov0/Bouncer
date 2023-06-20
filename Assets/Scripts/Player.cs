using UnityEngine;


public class Player : MonoBehaviour
{
   public Color Color { get;  set; }
   private Renderer _renderer;
   private ShapeManager _shapeManager;

   public void Initialize()
   {
      _renderer = GetComponent<Renderer>();
      var color = Color.white;
      _renderer.material.color = color;
      Color = color;
   }
   
}
