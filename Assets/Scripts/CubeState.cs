using UnityEngine;

public class CubeState : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private Transform _spawnPoint;

    public void GoCube()
    {
        GameObject cubeClone = Instantiate(_cube, _spawnPoint.transform.position, Quaternion.identity);
    }
}
