using UnityEngine;
using System.Collections;
using Rewired;

public class PaddleMovement : MonoBehaviour
{

    public int playerId = 0;
    public float moveSpeed = 3f;

    private Player player;
    private Vector3 moveVector2;

    void Awake()
    {
        player = ReInput.players.GetPlayer(playerId);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetInput();
        ProcessInput();

	
	}

    private void GetInput()
    {
        moveVector2.y = player.GetAxis("Move Vertical");
        
    }

    private void ProcessInput()
    {
        transform.Translate(moveVector2 * moveSpeed *Time.deltaTime);  
       // if(moveVector2.y != 0.0f)
            
            
        
    }
}
