using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuutiokoodi1 : MonoBehaviour
{
    //M‰‰ritell‰‰n ja alustetaan laskuri-muuttuja
    private float laskuri = 0;
    //T‰h‰n haetaan laskuriteksti-olio valmiiksi
    private GameObject tekstiolio = null;

    //T‰m‰ suoritetaan vain kerran

    void Start()
    {
        //Haetaan vain kerran, niin ei tuhlata resursseja
        this.tekstiolio = GameObject.Find("laskuriteksti");
    }   //Start

    //T‰m‰ suoritetaan jokaisella pelisilmukan kierroksella
    void Update()
    {
        if (this.laskuri < 300)
        {
            //Pyˆritet‰‰n kuutiota suhteellisesti kaikkien akseleiden ymp‰ri
            this.GetComponent<Transform>().Rotate(140f * Time.deltaTime, 70f * Time.deltaTime, 250f * Time.deltaTime);
            //Kasvatetaan laskuria yhdell‰
            this.laskuri = laskuri + Time.deltaTime * 20;
            //Tulostetaan laskurin arvo tekstiolioon
            this.tekstiolio.GetComponent<TextMesh>().text = "LASKURI: " + this.laskuri.ToString("0");
            Debug.Log("LASKURI: " + this.laskuri);
        } else {
            //Pudotetaan kuutio
            this.GetComponent<Rigidbody>().isKinematic = false;
            //Muutetaan teksti punaiseksi ja vaihdetaan tekstiksi "PUTOAA"
            this.tekstiolio.GetComponent<TextMesh>().color = new Color(1f, 0f, 0f);
            this.tekstiolio.GetComponent<TextMesh>().text = "PUTOAA";
        } //if
    } //Update
} //class
