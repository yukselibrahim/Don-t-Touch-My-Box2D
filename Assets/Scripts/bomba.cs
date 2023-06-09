using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    float darbeGucu;
    [SerializeField] GameObject topYokolmaefekt;
    [SerializeField] AudioSource yokOlmasesi;
    [SerializeField] GameObject gameKontrol;

    ortadaki_kutu ortadaki_kutularin_yönetimi;

    void Start()
    {
        darbeGucu = 20f;
        gameKontrol = GameObject.FindWithTag("GameKontrol");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DigerKutular"))
        {
            collision.gameObject.GetComponent<ortadaki_kutu>().DarbeAl(darbeGucu);

            gameKontrol.GetComponent<GameKontrol>().Ses_ve_Efekt_Olustur(1,collision.gameObject);

          

            Destroy(gameObject);
            //GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }

    void Update()
    {
        
    }
}
