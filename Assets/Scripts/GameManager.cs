using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private ShapeManager _shapeManager;
    [SerializeField] private Player _player;
    private void Awake()
    {
        _player.Initialize();
        _shapeManager.Initialize();
    }
    
    
    
    
    

    
}
