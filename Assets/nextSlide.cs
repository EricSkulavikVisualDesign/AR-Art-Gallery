using UnityEngine;
using Vuforia;


public class nextSlide : MonoBehaviour, IVirtualButtonEventHandler
{
	#region PUBLIC_MEMBERS

	public GameObject Slide1;
	public GameObject Slide2;
	public GameObject Slide3;
	public GameObject Slide4;
	public GameObject Slide5;
	public GameObject guy1;
    public GameObject guy2;
    public GameObject guy3;
	AudioSource aud;

	public GameObject vbBtnObj;

	#endregion // PUBLIC_MEMBERS


	#region MONOBEHAVIOUR_METHODS
	void Start()
	{

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		aud = GetComponent<AudioSource>();

		Slide1.SetActive(true);
		Slide2.SetActive(false);
		Slide3.SetActive(false);
		Slide4.SetActive(false);

	
	}

	#endregion // MONOBEHAVIOUR_METHODS


	#region PUBLIC_METHODS
	/// <summary>
	/// Called when the virtual button has just been pressed:
	/// </summary>
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		
		Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
		guy1.SetActive(false);
        guy2.SetActive(false);
        guy3.SetActive(false);
		aud.Stop();

		if(Slide1.activeSelf){
			Slide1.SetActive(false);
			Slide2.SetActive(true);
		}
		else if(Slide2.activeSelf){
			Slide2.SetActive(false);
			Slide3.SetActive(true);
		}
		else if(Slide3.activeSelf){
			Slide3.SetActive(false);
			Slide4.SetActive(true);
		}
		else if(Slide4.activeSelf){
			Slide4.SetActive(false);
			Slide5.SetActive(true);
		}
		else if(Slide5.activeSelf){
			Slide5.SetActive(false);
			Slide1.SetActive(true);
		}

	}

	/// <summary>
	/// Called when the virtual button has just been released:
	/// </summary>
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
	}
	#endregion //PUBLIC_METHODS


}