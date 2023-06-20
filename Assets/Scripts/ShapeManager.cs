using UnityEngine;
using Random = UnityEngine.Random;

public class ShapeManager : MonoBehaviour
{
   [SerializeField] private ColorsExample _colorsExample;
   [SerializeField] private Cylinder _cylinderPrefab;
   [SerializeField] private Sphere _spherePrefab;
   [SerializeField] private float _cylinderCount = 6;
   [SerializeField] private float _randomRadius = 10;

   public void Initialize()
   {
      for (int i = 0; i < _cylinderCount; i++)
      {
         CreateCylinder();
      }
      
      CreateSphere();
   }

   private void SetShapePosition<T>(T shape) where T : MonoBehaviour
   {
      var randomPosition = Random.insideUnitCircle * _randomRadius;
      var shapePosition = shape.transform.position;

      shapePosition.x += randomPosition.x;
      shapePosition.z += randomPosition.y;
      shape.transform.position = shapePosition;
   }

   public void CreateSphere()
   {
      var sphere = Instantiate(_spherePrefab, transform);
      SetShapePosition<Sphere>(sphere);

      var sphereColor = _colorsExample.GetColor();
      sphere.Initialize(sphereColor);
   }

   private void CreateCylinder()
   {
      var cylinder = Instantiate(_cylinderPrefab, transform);
      SetShapePosition<Cylinder>(cylinder);

      var cylinderColor = _colorsExample.GetColor();
      cylinder.Initialize(cylinderColor);
   }

   

   
}
