using UnityEngine;

namespace NutsAndBolt
{
    public class Block : MonoBehaviour
    {
        [SerializeField] private HoleBlock _holeBlockPrefab;
        
        public void SpawnHole(Vector3 position)
        {
            var holeBlock = Instantiate(_holeBlockPrefab, transform);
            holeBlock.SetPosition(position);
        }
    }
}