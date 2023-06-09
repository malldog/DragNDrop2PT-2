using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laiks : MonoBehaviour {
	public Text laiks;
	public Text beigas;
    public Objekti objektuSkripts;
    public Laiks laikiSkripts;
    private float saktLaiku, t;
	public string m, s, h;
	void Start () {
		


		saktLaiku = Time.time;
	}

    void Update()
    {
        if (objektuSkripts.score < 12)
        {
            t = Time.time - saktLaiku;
            if(((int)t/60)< 10)
            {
                m = ((int)t/60).ToString("00");
            }else{
                m = ((int)t/60).ToString("0");
            }
            if ((t %60)<10){
                s = (t %60).ToString("00.0");
            }else{
                s=(t%60).ToString("0.0");
            }
            if (((int)t / 60) < 10){
                h=(((int)t/60)/ 60).ToString("00");
            } else{
                h=(((int)t/60)/ 60).ToString("0");
            }
            laiks.text = h+":" +m+":"+s;
        }
        if (objektuSkripts.score == 12){
            beigas.text = h+ ":"+m+":"+ s;
            if(t<60 ){
                objektuSkripts.star1.SetActive(true);
                objektuSkripts.star2.SetActive(true);
                objektuSkripts.star3.SetActive(true);
            }
            if(t>60&& t<90)
            {
                objektuSkripts.star1.SetActive(true);
                objektuSkripts.star2.SetActive(true);

            } else {
                objektuSkripts.star1.SetActive(true);
            }

        }
    }





}
