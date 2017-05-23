using UnityEngine;
using UnityEngine.UI;

public class sliderManager : MonoBehaviour 
{
	public Slider slider;
	public RectTransform positiveImage;
	public RectTransform negativeImage;

	void Start()
	{
		float value = slider.value;
		if (value < 0) {
			slider.fillRect = negativeImage;
		} 
		else 
		{
			slider.fillRect = positiveImage;
		}
	}

	public void refreshImages()
	{
		float value = slider.value;
		if (value < 0) {
			slider.fillRect = negativeImage;
		} 
		else 
		{
			slider.fillRect = positiveImage;
		}
	}
}
