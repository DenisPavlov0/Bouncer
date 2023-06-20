using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sphere : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    private Renderer _renderer;
    private ColorsExample _colorsExample;
    
    public void Initialize(Color color)
    {
        _renderer = GetComponent<Renderer>();
        var collider = GetComponent<Collider>();
        collider.isTrigger = true;
        var renderer = GetComponent<Renderer>();
        renderer.material.color = color;
    }
    
    private void OnTriggerEnter (Collider playerCollider)
    {
        if (playerCollider.CompareTag(PLAYER_TAG))
        {
            var player = playerCollider.GetComponent<Player>();
            var playerColor = player.GetComponent<Renderer>();
            Renderer sphereRenderer = GetComponent<Renderer>();
            Color sphereColor = sphereRenderer.material.color;
            playerColor.material.color= sphereColor;
            player.Color = sphereColor;
            ShapeManager shapeManager = FindObjectOfType<ShapeManager>();
            // Вызовите метод CreateSphere, передав цвета
            shapeManager.CreateSphere();
            // Удалите текущий префаб
            Destroy(gameObject);
        }
    }

}
