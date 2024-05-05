using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject save1;
    public GameObject save2;
    public GameObject save3;
    private Vector3 savePoint1;
    private Vector3 savePoint2;
    private Vector3 savePoint3;
    private PlayerSystem playerSystem;
    private IngameUI ingameUI;
    // Start is called before the first frame update
    void Start()
    {
        savePoint1 = save1.transform.position;
        savePoint2 = save2.transform.position;
        savePoint3 = save3.transform.position;
        playerSystem = GameObject.Find("Player").GetComponent<PlayerSystem>();
        ingameUI = GameObject.Find("Canvas").GetComponent<IngameUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This script should be added into water terrain
    // When player falls into water, life points are reduced and player respawn at its last save point
    void OnTriggerEnter(Collider other) {
        if(other.name == "Player") {
            ingameUI.LoseLife(--playerSystem.life); // Update UI
            respawn(other);
        }
    }

    public void respawn(Collider other){
        switch(playerSystem.save) {
            case 0:
                other.transform.position = new Vector3(10f, 2f, 28.91f);
                break;
            case 1:
                other.transform.position = savePoint1;
                break;
            case 2:
                other.transform.position = savePoint2;
                break;
            case 3:
                other.transform.position = savePoint3;
                break;
            default:
                Debug.Log("Save Point value is wrong! The initial value has to be 0");
                break;  
        }
    }
}
