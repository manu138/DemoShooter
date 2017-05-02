using UnityEngine;
using System.Collections;

//This class is used on the shooting state so when it enters the state, instantiates the prefab assigned as bullet
public class FireGun : StateMachineBehaviour 
{
	public AudioClip shootClip;
	public GameObject bulletPrefab;
	public float shootForce;
	public Transform gun;

	// OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if(gun == null)
			gun = animator.gameObject.transform.Find("arm_gun:Bip001 R UpperArm/arm_gun:Bip001 R Forearm/arm_gun:Bip001 R Hand/Bazooka1/ShooterSpawn"); // todo use full path for faster
	}

	// OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			if(gun)
			{
				GameObject bulletClone = Instantiate(bulletPrefab, gun.position, gun.rotation) as GameObject;
				bulletClone.GetComponent<Rigidbody>().AddForce(bulletClone.transform.forward * shootForce,ForceMode.Impulse);

				animator.GetComponent<AudioSource>().PlayOneShot(shootClip); 
				animator.SetTrigger("Shoot");
			}
		} 
	}
}
