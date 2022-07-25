using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class myPhotonPlayer : MonoBehaviour
{
    public PhotonView _photonView;
    private GameObject _gameObject;
    private Player[] _allPlayer;
    private int _numberInRoom;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _photonView = GetComponent<PhotonView>();
        foreach (Player p in _allPlayer)
        {
            if (p != PhotonNetwork.LocalPlayer)
            {
                _numberInRoom++;
            }
        }

        if (_photonView.IsMine)
        {
            _gameObject = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "AU_Player"),
                gameController.instance.spawnPoints[_numberInRoom].position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
