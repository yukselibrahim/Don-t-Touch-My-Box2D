using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{

    [SerializeField] GameObject bomba;
    [SerializeField] GameObject bombaCikisnoktasi;
    [SerializeField] ParticleSystem topAtisefekt;
    [SerializeField] AudioSource topAtmasesi;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bombaObjem = Instantiate(bomba, bombaCikisnoktasi.transform.position,bombaCikisnoktasi.transform.rotation);
            Rigidbody2D rg = bombaObjem.GetComponent<Rigidbody2D>();
            rg.AddForce(new Vector2(2f, 0f) * 8f, ForceMode2D.Impulse);
            topAtisefekt.Play(); //Yukarýda particlesystem olarak tanýmladýðýmýz için topAtisefekt i play getirip oynatabiliyoruz. 

            Instantiate(topAtisefekt, bombaCikisnoktasi.transform.position, bombaCikisnoktasi.transform.rotation); //Burada bomba çýkýþ noktasýna patlama efektini instantiate ettik.
            topAtmasesi.Play();
        }
    }
}
