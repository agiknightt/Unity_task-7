using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RespawnCoints : MonoBehaviour
{
    [SerializeField] private Transform _pointsSpawn;
    [SerializeField] private GameObject _coin;    

    private void Awake()
    {
        for (int i = 0; i < _pointsSpawn.childCount; i++)
        {
            Instantiate(_coin, _pointsSpawn.GetChild(i));
        }
    }    
}
