using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject e46;
	public GameObject e61;
	public GameObject cementa;
	public GameObject ekskavators;
	public GameObject policija;
	public GameObject traktors1;
	public GameObject traktors5;
	public GameObject ugunsdzesejs;
    public GameObject scoreBoard;
    public GameObject star1;
    public GameObject star1spot;
    public GameObject star2;
    public GameObject star2spot;
    public GameObject star3;
    public GameObject star3spot;
    public GameObject restartButton;
    public float score;
	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 cementaKoord;
    [HideInInspector]
    public Vector2 ekskavatorsKoord;
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 traktors1Koord;
    [HideInInspector]
    public Vector2 traktors5Koord;
    [HideInInspector]
    public Vector2 ugunsdzesejsKoord;

    public Canvas kanva;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		atkrMKoord =
		atkritumuMasina.GetComponent<RectTransform>().localPosition;

       atraPKoord =
       atraPalidziba.GetComponent<RectTransform>().localPosition;

		bussKoord =
        autobuss.GetComponent<RectTransform>().localPosition;

        b2Koord =
        b2.GetComponent<RectTransform>().localPosition;

        e46Koord =
        e46.GetComponent<RectTransform>().localPosition;

        e61Koord =
        e61.GetComponent<RectTransform>().localPosition;

        cementaKoord = cementa.GetComponent<RectTransform>().localPosition;
        ekskavatorsKoord = ekskavators.GetComponent<RectTransform>().localPosition;
        policijaKoord = policija.GetComponent<RectTransform>().localPosition;
        traktors1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        traktors5Koord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsdzesejsKoord = ugunsdzesejs.GetComponent<RectTransform>().localPosition;
  
}
}
