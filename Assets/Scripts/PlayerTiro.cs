using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerTiro : MonoBehaviour
{
    public GameObject Tiro;
    public GameObject mira;
    public float moveH;
    public float Velocidade;
    public float Time;
    public bool dirplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        moveH = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.A));
        {
            dirplayer = false;
        }
         if (Input.GetKeyDown(KeyCode.D));
        {
            dirplayer = true;
        }
          if (Input.GetMouseButtonDown(0));
        {
            Atira(dirplayer);
        }
        
        
        
    }

    private void Atira(bool direcao)
    {
        if(direcao)
        {
        Instantiate(
            Tiro,
            mira.transform.position,
            Quaternion.Euler(0, 0, -90)
        );
        }
        else
        {
            Instantiate(
                Tiro,
                mira.transform.position, Quaternion.Euler(0, 0, 90)).GetComponent<Tiro>().DirecaoTiro(-1);
        }
    }
    
}
