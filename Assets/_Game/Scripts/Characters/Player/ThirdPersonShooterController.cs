using UnityEngine;
using Cinemachine;
using StarterAssets;

public class ThirdPersonShooterController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;

	private StarterAssetsInputs starterAssetsInputs;

	private void Awake()
	{
		starterAssetsInputs = GetComponent<StarterAssetsInputs>();
	}

	private void Update()
	{
		if (starterAssetsInputs.aim)
		{
			aimVirtualCamera.gameObject.SetActive(true);
		}
		else
		{
			aimVirtualCamera.gameObject.SetActive(false);
		}
	}
}
