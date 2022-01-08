namespace RetroCaffe
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class RC_DoorScript : MonoBehaviour
    {

        public string playerTag = "Player";
        private bool inTrigger = false;
        private Animation doorAnim;
        public AnimationClip anim;
        private bool isOpen = false;

        // Use this for initialization
        void Start()
        {
            if (GetComponent<Animation>() != null)
            {
                doorAnim = GetComponent<Animation>();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (inTrigger)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (isOpen)
                    {
                        OpenCloseDoor(1, -1);
                        isOpen = false;
                    }
                    else
                    {
                        OpenCloseDoor(0, 1);
                        isOpen = true;
                    }


                }
            }
        }

        public void OpenCloseDoor(float _time, float _speed)
        {
            doorAnim[anim.name].normalizedTime = _time;
            doorAnim[anim.name].speed = _speed;
            doorAnim.Play();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == playerTag)
            {
                inTrigger = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == playerTag)
            {
                inTrigger = false;
            }
        }
    }
}
