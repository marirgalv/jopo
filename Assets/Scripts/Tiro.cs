using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tiro : MonoBehaviour
{
    public float velocidade;

    public int dano;
    public int dirTiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Contador");
            transform.position += new Vector3(dirTiro * velocidade * Time.deltaTime,0 ,0);
    }
    private IEnumerator Contador()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }

    public void DirecaoTiro(int dir)
    {
        dirTiro = dir;
    }
}
