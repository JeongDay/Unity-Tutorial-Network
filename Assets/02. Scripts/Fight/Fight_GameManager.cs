using System.Collections;
using Photon.Pun;
using UnityEngine;

public class Fight_GameManager : MonoBehaviourPun
{
    IEnumerator Start()
    {
        yield return null;
        
        var randomPos = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        PhotonNetwork.Instantiate("Fight_Player", randomPos, Quaternion.identity);
    }
}