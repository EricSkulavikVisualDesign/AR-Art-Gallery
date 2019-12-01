using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class readText : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public AudioClip track1;
    public AudioClip track2;
    public AudioClip track3;
    public AudioClip track4Music;
    public UnityEngine.Video.VideoPlayer vid;
    public GameObject Slide1;
	public GameObject Slide2;
	public GameObject Slide3;
	public GameObject Slide4;
    public GameObject Slide5;
    public GameObject guy1;
    public GameObject guy2;
    public GameObject guy3;
    public Animator ani1;
    public Animator ani2;
    public Animator ani3;
	public int i;
    AudioSource aud;
    public bool on = false;



    // Start is called before the first frame update
    void Start()
    {
       
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vid.GetComponent<UnityEngine.Video.VideoPlayer>(); 
        ani1.GetComponent<Animator>();
        ani2.GetComponent<Animator>();
        ani3.GetComponent<Animator>();

        guy1.SetActive(false);
        guy2.SetActive(false);
        guy3.SetActive(false);
        

        aud = GetComponent<AudioSource>();
        track1.LoadAudioData();
        track2.LoadAudioData();
        track3.LoadAudioData();
        track4Music.LoadAudioData();

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        aud.Stop();
        //vid.Stop();
        ani1.Play("none");
        ani2.Play("none");
        ani3.Play("none");
        
        guy1.SetActive(false);
        guy2.SetActive(false);
        guy3.SetActive(false);

        if(Slide1.activeSelf){
            aud.PlayOneShot(track1, 2F);
            guy1.SetActive(true);
            ani1.Play("Take 001");

        }
        if(Slide2.activeSelf){
            aud.PlayOneShot(track2, 2F);
            guy2.SetActive(true);
            ani2.Play("Take 001");
            
        }
        if(Slide3.activeSelf){
            aud.PlayOneShot(track3, 2F);
            guy3.SetActive(true);
            ani3.Play("Take 001");
        }
        if(Slide4.activeSelf){  //other works, do music
            aud.PlayOneShot(track4Music, 2F);
        }
        if(Slide5.activeSelf){  //video
            vid.Play();
        }
        

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}