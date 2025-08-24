using NutsAndBolt;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    // [Header("")]
    [SerializeField] private LayerMask _spawnHoleLayerMask;
    
    private void Awake()
    {
        GetHits();
    }

    // Get collision point = hit
    private void GetHits()
    {
        var origin = transform.position;
        var direction = Vector3.forward;
        
        Debug.DrawRay(origin, direction * 10f, Color.red, 15);
        
        // Raycast Hit -> cast collision through collider
        var hits = new RaycastHit2D[20];

        var hitCount = Physics2D.RaycastNonAlloc(origin, direction, hits, 10f, _spawnHoleLayerMask);

        for (var i = 0; i < hitCount; i++)
        {
            var hit = hits[i];
            
            var block = hit.collider.GetComponentInParent<Block>();
            
            if (block == null) continue;

            block.SpawnHole(transform.position);
        }
        
    }
}
